using System;
using System.Collections.Generic;
using System.Text;

namespace covid.Core.Entities.Generated
{
    internal class OverviewJson
    {
        public DateTime modified { get; set; }
        public string source { get; set; }
        public Data[] data { get; set; }
    }

    internal class Data
    {
        public string datum { get; set; }
        public int provedene_testy_celkem { get; set; }
        public int potvrzene_pripady_celkem { get; set; }
        public int aktivni_pripady { get; set; }
        public int vyleceni { get; set; }
        public int umrti { get; set; }
        public int aktualne_hospitalizovani { get; set; }
        public int provedene_testy_vcerejsi_den { get; set; }
        public int potvrzene_pripady_vcerejsi_den { get; set; }
        public int potvrzene_pripady_dnesni_den { get; set; }
        public string provedene_testy_vcerejsi_den_datum { get; set; }
        public string potvrzene_pripady_vcerejsi_den_datum { get; set; }
        public string potvrzene_pripady_dnesni_den_datum { get; set; }
        public int provedene_antigenni_testy_celkem { get; set; }
        public int provedene_antigenni_testy_vcerejsi_den { get; set; }
        public string provedene_antigenni_testy_vcerejsi_den_datum { get; set; }
        public int vykazana_ockovani_celkem { get; set; }
        public int vykazana_ockovani_vcerejsi_den { get; set; }
        public string vykazana_ockovani_vcerejsi_den_datum { get; set; }
    }

}
