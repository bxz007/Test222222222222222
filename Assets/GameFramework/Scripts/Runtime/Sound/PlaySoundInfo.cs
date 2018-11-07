//------------------------------------------------------------
// Game Framework v3.x
// Copyright © 2013-2018 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using UnityEngine;

namespace UnityGameFramework.Runtime
{
    internal sealed class PlaySoundInfo
    {
        private readonly VarTransform m_BindingTransform;
        private readonly Vector3 m_WorldPosition;
        private readonly object m_UserData;

        public PlaySoundInfo(VarTransform bindingTransform, Vector3 worldPosition, object userData)
        {
            m_BindingTransform = bindingTransform;
            m_WorldPosition = worldPosition;
            m_UserData = userData;
        }

        public VarTransform BindingTranform
        {
            get
            {
                return m_BindingTransform;
            }
        }

        public Vector3 WorldPosition
        {
            get
            {
                return m_WorldPosition;
            }
        }

        public object UserData
        {
            get
            {
                return m_UserData;
            }
        }
    }
}
