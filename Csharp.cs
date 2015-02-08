#region //run方法
/// <summary>
/// 通过路径启动应用程序。
/// </summary>
/// <param name="path">可执行程序exe的完整路径</param>
/// <returns>void</returns>
public void run(string path) {
    ProcessStartInfo startInfo = new ProcessStartInfo(path);
    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
    Process.Start(startInfo);
}    
#endregion