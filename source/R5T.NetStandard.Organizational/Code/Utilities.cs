using System;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.IO.Paths.Extensions;

using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;


namespace R5T.NetStandard.Organizational
{
    public static class Utilities
    {
        public static string AppendDataDirectory(string directoryPath)
        {
            var output = PathUtilities.Combine(directoryPath, Constants.DataDirectoryNameValue);
            return output;
        }

        public static DirectoryPath AppendDataDirectory(DirectoryPath directoryPath)
        {
            var output = Utilities.AppendDataDirectory(directoryPath.Value).AsDirectoryPath();
            return output;
        }

        public static string AppendOrganizationsDirectory(string directoryPath)
        {
            var output = PathUtilities.Combine(directoryPath, Constants.OrganizationsDirectoryNameValue);
            return output;
        }

        public static DirectoryPath AppendOrganizationsDirectory(DirectoryPath directoryPath)
        {
            var output = Utilities.AppendOrganizationsDirectory(directoryPath.Value).AsDirectoryPath();
            return output;
        }

        public static string AppendDefaultOrganizationDirectory(string directoryPath, IOrganization organization)
        {
            var defaultOrganizationDirectoryNameValue = organization.GetDefaultDirectoryNameValue();

            var output = PathUtilities.Combine(directoryPath, defaultOrganizationDirectoryNameValue);
            return output;
        }

        public static DirectoryPath AppendDefaultOrganizationDirectory(DirectoryPath directoryPath, IOrganization organization)
        {
            var output = Utilities.AppendDefaultOrganizationDirectory(directoryPath.Value, organization).AsDirectoryPath();
            return output;
        }

        public static string AppendOrganizationsAndDefaultOrganizationDirectories(string directoryPath, IOrganization organization)
        {
            var organizationsDirectory = Utilities.AppendOrganizationsDirectory(directoryPath);

            var output = Utilities.AppendDefaultOrganizationDirectory(organizationsDirectory, organization);
            return output;
        }

        public static DirectoryPath AppendOrganizationsAndDefaultOrganizationDirectories(DirectoryPath directoryPath, IOrganization organization)
        {
            var output = Utilities.AppendOrganizationsAndDefaultOrganizationDirectories(directoryPath.Value, organization).AsDirectoryPath();
            return output;
        }
    }
}
