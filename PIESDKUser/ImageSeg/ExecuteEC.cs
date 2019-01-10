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

namespace PIESDKUser
{
    public class ExecuteEC:BaseCommand
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
            if (RuleSetMessage.imagePath != null)
            {
                ILayer layer = LayerFactory.CreateDefaultLayer(RuleSetMessage.imagePath);
            }
        }
    }
}
