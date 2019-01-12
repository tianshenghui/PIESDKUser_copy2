using PIE.AxControls;
using PIE.Carto;
using PIE.Controls;
using PIE.SystemUI;
using PIE.Display;
using PIE.Geometry;
using PIE.Plugin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sparkle
{
    /// <summary>
    /// 拉框放大
    /// </summary>
    public class ZoomIn : BaseTool
    { 
        #region 变量
        private IActiveView m_ActiveView = null;
        
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public ZoomIn()
        {
            this.Caption = "拉框放大";
            this.Name = "MapZoomIn";
            this.ToolTip = "拉框放大地图";
            this.Checked = false;
            this.Enabled = false;
            this.Cursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.ZoomIn));
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
        }

        /// <summary>
        /// 鼠标按下
        /// </summary>
        /// <param name="sender">触发对象</param>  
        /// <param name="e">鼠标事件参数</param>
        public override void OnMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left) return;

            m_ActiveView.Extent = (m_HookHelper.GetContent() as IMapControl).TrackRectangle();
            m_ActiveView.PartialRefresh(ViewDrawPhaseType.ViewAll);
        }
    }
}
