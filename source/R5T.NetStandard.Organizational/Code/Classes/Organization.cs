using System;


namespace R5T.NetStandard.Organizational
{
    public class Organization : IOrganization
    {
        public string Name { get; set; }


        public Organization()
        {
        }

        public Organization(string name)
        {
            this.Name = name;
        }
    }
}
