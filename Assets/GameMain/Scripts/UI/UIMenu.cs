using GameFramework;
using UnityEngine;
using UnityGameFramework.Runtime;
using UnityEngine.UI;


namespace GameMain
{
    public class UIMenu : UGuiForm
    {       
        private ProcedureMenu m_ProcedureMenu = null;

        public void OnStartButtonClick()
        {
            //GameEntry.Sound.PlayUISound(10001);
            m_ProcedureMenu.StartGame();
        }
         

#if UNITY_2017_3_OR_NEWER
        protected override void OnOpen(object userData)
#else
        protected internal override void OnOpen(object userData)
#endif
        {
            base.OnOpen(userData);
            m_ProcedureMenu = (ProcedureMenu)userData;
            if (m_ProcedureMenu == null)
            {
                Log.Warning("ProcedureMenu is invalid when open MenuForm.");
                return;
            }
        }

#if UNITY_2017_3_OR_NEWER
        protected override void OnClose(object userData)
#else
        protected internal override void OnClose(object userData)
#endif
        {
            m_ProcedureMenu = null;

            base.OnClose(userData);
        }
    }
}
