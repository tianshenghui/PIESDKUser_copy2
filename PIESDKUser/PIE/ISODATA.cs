using System;
using System.Collections.Generic;
using System.Linq;
using PIE.Plugin;
using PIE.CommonAlgo;
using PIE.SystemAlgo;
using PIE.Carto;
using PIE.DataSource;
using PIE.Controls;
using System.Windows.Forms;
using System.ComponentModel;
namespace Sparkle
{
    class MyISODATA:BaseCommand
    {        
        public override void OnCreate(object hook)
        {
            if (hook == null) return;
            if (!(hook is IPmdContents)) return;
            this.Enabled = true;
            m_Hook = hook;
            m_HookHelper.Hook = hook;
        }
        public  override void OnClick()
        {

            ISODATA_FRM myIODATA_FRM = new ISODATA_FRM();
            if (myIODATA_FRM.ShowDialog() != DialogResult.OK) return;
            ISODataClassification_Exchange_Info iSODataClassification = new ISODataClassification_Exchange_Info();
            iSODataClassification = ISODATA_FRM.ISODataParams;
            ISODataClassificationAlgo iSODataClassificationAlgo = new ISODataClassificationAlgo
            {
                Params = iSODataClassification
            };
            Application.DoEvents();
            AlgoFactory.Instance().AsynExecuteAlgo(iSODataClassificationAlgo);

            ISystemAlgoEvents systemAlgoEvents = iSODataClassificationAlgo as ISystemAlgoEvents;
            systemAlgoEvents.OnExecuteCompleted += OnAlgoExecuteCompleted;
            systemAlgoEvents.OnProgressChanged += OnAlgoProgresChanged;
            
        }
        private void OnAlgoExecuteCompleted(ISystemAlgo algo)
        {
           
           ILayer layer = LayerFactory.CreateDefaultLayer(ISODATA_FRM.ISODataParams.OutputFilePath);      
            m_HookHelper.FocusMap.AddLayer(layer);
            m_HookHelper.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            ISystemAlgoEvents algoEvents = algo as ISystemAlgoEvents;
            algoEvents.OnExecuteCompleted -= OnAlgoExecuteCompleted;
            algoEvents.OnProgressChanged -= OnAlgoProgresChanged;
            MainForm.parentForm.myProgressBar.Value = 0;
            MainForm.parentForm.myLabel.Text ="";
        }
        private int OnAlgoProgresChanged(double complete, string msg, ISystemAlgo algo)
        {


            MethodInvoker invoker = () => { MainForm.parentForm.myProgressBar.Value = Convert.ToInt16(complete);              
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
