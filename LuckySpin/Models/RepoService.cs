using System.Collections.Generic;
using System;
namespace LuckySpin.Models
{

    public class RepoService
    {
        private List<Spin> spins = new List<Spin>();

        public IEnumerable<Spin> Spins { get { return spins; } }


        public void AddSpin(Spin spin)
        {
            spins.Add(spin);
        }
    }
        
}

