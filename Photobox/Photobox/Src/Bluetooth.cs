using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Sockets;
using Windows.Networking.Proximity;
using System.Windows;
using System.Diagnostics;

namespace Photobox.Src
{
    class Bluetooth
    {
        /*ObservableCollection<PeerAppInfo> _peerApps;    // A local copy of peer app information
        StreamSocket _socket;                           // The socket object used to communicate with a peer
        string _peerName = string.Empty;*/                // The name of the current peer

        public void start()
        {
            try
            {
                PeerFinder.DisplayName = "Windows Phone 8.0";
                PeerFinder.Start();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Habilite a capability ID_CAP_PROXIMITY no WMAppManifest.xml");
            }
        }

        public async void findPeers()
        {
            try
            {
                IReadOnlyList<PeerInformation> peers = await PeerFinder.FindAllPeersAsync();
               
                if (peers.Count > 0)
                {

                }
            }
            catch (System.Exception ex)
            {
                if ((uint)ex.HResult == BluetoothError.ERR_BLUETOOTH_OFF)
                {
                    MessageBox.Show("Habilite o Bluetooth do dispositivo");
                }
                else if ((uint)ex.HResult == BluetoothError.ERR_NOT_ADVERTISING)
                {
                    MessageBox.Show("2");
                }
                else
                {
                    MessageBox.Show("3");
                }
            }
            
        }
    }
}
