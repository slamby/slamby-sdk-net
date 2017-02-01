namespace Slamby.SDK.Net
{
    public static class Constants
    {
        public const string DataSetHeader = "X-DataSet";

        public const string AuthorizationHeader = "Authorization";

        public const string AuthorizationMethodSlamby = "Slamby";

        public const string ApiVersionHeader = "X-Api-Version";

        public const string SdkVersionHeader = "X-Sdk-Version";

        public const string ApiParallelLimitHeader = "X-Api-Parallel-Limit";

        public const string ValidationCommonRegex = "^([a-zA-Z0-9-_]+)$";
        public const int ValidationCommonMinimumLength = 3;
        public const int ValidationCommonMaximumLength = 50;
        public const int ValidationCommonMaximumNumber = 10000;
    }
}
