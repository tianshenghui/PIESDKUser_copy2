using PIE.Carto;
using PIE.Controls;
using PIE.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIESDKUser
{
    /// <summary>
    /// 全图显示
    /// </summary>
    public class FullExtent : BaseCommand
    {
        private IActiveView m_ActiveView = null;
        /// <summary>
        /// 构造函数
        /// </summary>
        public FullExtent()
        {
            this.Caption = "全图显示";
            this.Name = "MapFullExtent";
            this.ToolTip = "全图显示地图";
            this.Checked = false;
            this.Enabled = false;
        }

        /// <summary>
        /// 创建插件对象
        /// </summary>
        /// <param name="hook"></param>
        public override void OnCreate(object hook) 
        {
            base.OnCreate(hook);
            m_ActiveView = m_HookHelper.ActiveView;
        }

        /// <summary>
        /// 单击方法
        /// </summary>
        public override void OnClick()
        {
            if (!this.Enabled) return;

            IEnvelope currentExtent = m_ActiveView.FullExtent;
            if (currentExtent == null || (currentExtent as IGeometry).IsValid() == false) return;

            m_ActiveView.Extent = currentExtent;
            m_ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }
    }
}
