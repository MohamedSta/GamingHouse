using System;
using System.Collections.Generic;

namespace gaming.data.Models
{
    public partial class sponsor
    {
        public int idSponsor { get; set; }
        public string addressSponsor { get; set; }
        public string entreprise { get; set; }
        public string location { get; set; }
        public string nameSponsor { get; set; }
        public string phonenumberSponsor { get; set; }
        public byte[] picture { get; set; }
        public string date { get; set; }
    }
}
