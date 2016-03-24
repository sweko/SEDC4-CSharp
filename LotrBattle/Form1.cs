using LotrEntities;
using LotrEntities.Warriors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotrBattle
{
    public partial class Form1 : Form
    {
        public IEnumerable<IWarrior> BadGuys { get; set; }
        public IEnumerable<IWarrior> GoodGuys { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var factory = new WarriorFactory();
            BadGuys = factory.GetBadGuys(10);
            GoodGuys = factory.GetGoodGuys(10);
            RefreshDisplay();
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            var gg = GoodGuys.ToList();
            var bg = BadGuys.ToList();

            Random r = new Random();
            while (GoodGuys.Any() && BadGuys.Any())
            {
                var ggIndex = r.Next(GoodGuys.Count());
                var bgIndex = r.Next(BadGuys.Count());
                var gvIndex = r.Next(GoodGuys.Count());
                var bvIndex = r.Next(BadGuys.Count());

                gg[ggIndex].Attack(bg[bvIndex]);
                bg[bgIndex].Attack(gg[gvIndex]);

                if (!gg[gvIndex].IsAlive)
                {
                    gg.RemoveAt(gvIndex);
                }
                if (!bg[bvIndex].IsAlive)
                {
                    bg.RemoveAt(bvIndex);
                }
                GoodGuys = gg;
                BadGuys = bg;
                Thread.Sleep(10);
                RefreshDisplay();
            }
        }

        private void RefreshDisplay()
        {
            lstBadGuys.DataSource = null;
            lstGoodGuys.DataSource = null;
            lstBadGuys.DataSource = BadGuys;
            lstGoodGuys.DataSource = GoodGuys;
        }
    }
}
