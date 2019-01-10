using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PIE.CommonAlgo;
using PIE.SystemAlgo;
using PIE.Carto;
using PIE.Controls;
using System.Windows.Forms;
namespace PIESDKUser
{
    class PCAfusion:BaseCommand
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
            PCAfusion_FRM pCAfusion_FRM = new PCAfusion_FRM();
            if (pCAfusion_FRM.ShowDialog() != DialogResult.OK) return;
            Pansharp_Exchange_Info PCAfusionParams = new Pansharp_Exchange_Info();
            PCAfusionParams = PCAfusion_FRM.PCAfusionParam;
            PansharpFuseAlgo PCAfusionAlgo = new PansharpFuseAlgo
            {
                Params=PCAfusionParams
            };
            Application.DoEvents();
            AlgoFactory.Instance().AsynExecuteAlgo(PCAfusionAlgo);
            ISystemAlgoEvents systemAlgoEvents = PCAfusionAlgo as ISystemAlgoEvents;
            systemAlgoEvents.OnExecuteCompleted += OnAlgoExecuteCompleted;
            systemAlgoEvents.OnProgressChanged += OnAlgoProgresChanged;
        }
        private void OnAlgoExecuteCompleted(ISystemAlgo algo)
        {
            ILayer layer = LayerFactory.CreateDefaultLayer(PCAfusion_FRM.PCAfusionParam.OutputFilePath);       
            m_HookHelper.FocusMap.AddLayer(layer);
            m_HookHelper.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            ISystemAlgoEvents algoEvents = algo as ISystemAlgoEvents;
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
