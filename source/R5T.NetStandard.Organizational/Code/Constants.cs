using System;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.IO.Paths.Extensions;


namespace R5T.NetStandard.Organizational
{
    public static class Constants
    {
        public const string DataDirectoryNameValue = "Data";
        public static readonly DirectoryName DataDirectoryName = Constants.DataDirectoryNameValue.AsDirectoryName();
        public const string OrganizationsDirectoryNameValue = "Organizations";
        public static readonly DirectoryName OrganizationsDirectoryName = Constants.OrganizationsDirectoryNameValue.AsDirectoryName();
    }
}
