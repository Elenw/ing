﻿namespace Sakuno.KanColle.Amatsukaze
{
    static class PackageUtil
    {
        public const string PackageManifestFilename = "package.nuspec";

        public static string GetFilenameExceptLibDirectory(string uri, string relationship)
        {
            if (uri == relationship)
                return PackageManifestFilename;

            return uri.Replace('/', '\\');
        }

        public static string GetFilenameInLibDirectory(string uri) => uri.Substring(uri.LastIndexOf('/') + 1);
    }
}
