namespace BetterMC.Core.Installations.Loader
{
    public sealed class LaunchArguments
    {
        public static string DefaultJavaArgs =
            "-XX:+UnlockExperimentalVMOptions " +
                "-XX:+UseG1GC " +
                "-XX:G1NewSizePercent=20 " +
                "-XX:G1ReservePercent=20 " +
                "-XX:MaxGCPauseMillis=50 " +
                "-XX:G1HeapRegionSize=16M";

        public static void BuildArgs()
        {

        }
    }
}
