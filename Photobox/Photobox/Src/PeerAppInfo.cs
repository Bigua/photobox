using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Proximity;

namespace Photobox.Src
{
    class PeerAppInfo
    {
        public PeerAppInfo(PeerInformation peerInformation)
        {
            this.PeerInfo = peerInformation;
            this.DisplayName = this.PeerInfo.DisplayName;
            //this.HostName = this.PeerInfo.HostName.DisplayName;
            //this.ServiceName = this.PeerInfo.ServiceName;
        }

        public PeerInformation PeerInfo { get; set; }

        public string DisplayName { get; set; }

        //public string HostName { get; private set; }
        //public string ServiceName { get; private set; }
    }
}
