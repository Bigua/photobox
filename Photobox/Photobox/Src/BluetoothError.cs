using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photobox.Src
{
    class BluetoothError
    {
        // Error code constants
        public const uint ERR_BLUETOOTH_OFF = 0x8007048F;      // The Bluetooth radio is off
        public const uint ERR_MISSING_CAPS = 0x80070005;       // A capability is missing from your WMAppManifest.xml
        public const uint ERR_NOT_ADVERTISING = 0x8000000E;    // You are currently not advertising your presence using PeerFinder.Start()
    }
}
