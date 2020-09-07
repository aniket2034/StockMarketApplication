using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketLibrary
{
    public class TokenDetails
    {
        public TokenDetails(string token, int user)
        {
            this.token = token;
            usertype = user;
        }

        public int usertype { get; set; }

        public string token { get; set; }

    }
}
