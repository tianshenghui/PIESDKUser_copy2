using System;
using  PIE.Plugin ;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PIE.Controls;
using System.Windows.Forms;
using PIE.CommonAlgo;
using PIE.SystemAlgo;
using PIE.Carto;
using System.Runtime.InteropServices;
namespace PIESDKUser
{
    public class Neural:BaseCommand 
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
            Neural_FRM neural_From = new Neural_FRM();
            if (neural_From.ShowDialog() != DialogResult.OK) return;
            NeuralNetworkCluster_Exchange_Info neuralNet = new NeuralNetworkCluster_Exchange_Info();
           neuralNet = Neural_FRM.NeuralEx; //访问静态成员
            

            NeuralNetworkClusterAlgo neuralN_Algo = new NeuralNetworkClusterAlgo { Params = neuralNet };

            AlgoFactory.Instance().AsynExecuteAlgo(neuralN_Algo);
            ISystemAlgoEvents systemAlgoEvents = neuralN_Algo as ISystemAlgoEvents;
            systemAlgoEvents.OnExecuteCompleted += OnAlgoExecuteCompleted; ///??
            systemAlgoEvents.OnProgressChanged += OnAlgoProgresChanged;
          

           
            
        }
        private void OnAlgoExecuteCompleted(ISystemAlgo Algo)
        {
            ILayer layer = LayerFactory.CreateDefaultLayer(Neural_FRM.NeuralEx.OutputFilePath);                
            m_HookHelper.FocusMap.AddLayer(layer);
            m_HookHelper.ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
            ISystemAlgoEvents algoEvents = Algo as ISystemAlgoEvents;
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
