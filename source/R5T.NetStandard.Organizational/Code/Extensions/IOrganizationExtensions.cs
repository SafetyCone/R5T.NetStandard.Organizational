using System;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.IO.Paths.Extensions;


namespace R5T.NetStandard.Organizational
{
    public static class IOrganizationExtensions
    {
        /// <summary>
        /// The default directory name for an <see cref="IOrganization"/> is the name of the organization.
        /// </summary>
        public static string GetDefaultDirectoryNameValue(this IOrganization organization)
        {
            var output = organization.Name;
            return output;
        }

        /// <summary>
        /// The default directory name for an <see cref="IOrganization"/> is the name of the organization.
        /// </summary>
        public static DirectoryName GetDefaultDirectoryName(this IOrganization organization)
        {
            var output = organization.GetDefaultDirectoryNameValue().AsDirectoryName();
            return output;
        }
    }
}
