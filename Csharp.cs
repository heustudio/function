#region //run����
/// <summary>
/// ͨ��·������Ӧ�ó���
/// </summary>
/// <param name="path">��ִ�г���exe������·��</param>
/// <returns>void</returns>
public void run(string path) {
    ProcessStartInfo startInfo = new ProcessStartInfo(path);
    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
    Process.Start(startInfo);
}    
#endregion