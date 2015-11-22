namespace Rackjaw.Entities
{
    using System.Collections.Generic;

    public class Vault
    {
        public string Name { get; set; }

        public List<Secret> Secrets { get; set; }
    }
}
