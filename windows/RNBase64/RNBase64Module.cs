using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Base64.RNBase64
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBase64Module : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBase64Module"/>.
        /// </summary>
        internal RNBase64Module()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBase64";
            }
        }
    }
}
