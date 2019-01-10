using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PIE.CommonAlgo;
using PIE.Plugin;
using PIE.Carto;
using PIE.SystemAlgo;
using PIE.AxControls;
using PIE.Controls;
using System.Windows.Forms;
namespace PIESDKUser
{
    class KMeans:KmeansClassificationCommand
    {
        public override void OnCreate(object hook)
        {
            if (hook == null) return;
            if (!(hook is IPmdContents)) return;
            this.Enabled = true;
            m_Hook = hook;
            m_HookHelper.Hook = hook;
        }
        public override void OnClick()
        {
            FrmKmeansClassification frmKmeansClassification = new FrmKmeansClassification();
            if (frmKmeansClassification.ShowDialog() != DialogResult.OK) return;
            KmeansClassification_Exchange_Info KmeansClassification = new KmeansClassification_Exchange_Info();
            KmeansClassification = frmKmeansClassification.ExChangeData;
            KmeansClassificationAlgo kmeansClassificationAlgo = new KmeansClassificationAlgo
            {
                Params = KmeansClassification
            };
            Application.DoEvents();
            AlgoFactory.Instance().AsynExecuteAlgo(kmeansClassificationAlgo);
            ISystemAlgoEvents systemAlgoEvents = kmeansClassificationAlgo as ISystemAlgoEvents;
            systemAlgoEvents.OnExecuteCompleted += OnAlgoExecuteCompleted;
            systemAlgoEvents.OnProgressChanged += OnAlgoProgresChanged;
        }
        private void OnAlgoExecuteCompleted(PIE.SystemAlgo.ISystemAlgo algo)
        {
            KmeansClassification_Exchange_Info info = (KmeansClassification_Exchange_Info)algo.Params;
            PIE.Carto.ILayer layer = PIE.Carto.LayerFactory.CreateDefaultLayer(info.OutputFilePath);
            m_HookHelper.FocusMap.AddLayer(layer);
            m_HookHelper.ActiveView.PartialRefresh(PIE.Carto.ViewDrawPhaseType.ViewAll);

            PIE.SystemAlgo.ISystemAlgoEvents algoEvents = algo as PIE.SystemAlgo.ISystemAlgoEvents;
            algoEvents.OnExecuteCompleted -= OnAlgoExecuteCompleted;
            algoEvents.OnProgressChanged -= OnAlgoProgresChanged;
            MainForm.parentForm.myProgressBar.Value = 0;
            MainForm.parentForm.myLabel.Text = "";
        }
        private int OnAlgoProgresChanged(double complete, string msg, ISystemAlgo algo)
        {
            MethodInvoker invoker = () => {
                MainForm.parentForm.myProgressBar.Value = Convert.ToInt16(complete);
                MainForm.parentForm.myLabel.Text = Convert.ToByte(complete).ToString()+"%";
            };

            if (MainForm.parentForm.myProgressBar.InvokeRequired)
            {
                MainForm.parentForm.myProgressBar.Invoke(invoker);
            }
            else
            {
                invoker();
            }
            return 0;
        }

    }
}
