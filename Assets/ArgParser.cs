namespace Nsm {

sealed class ArgParser
{
    public bool HasSource => !string.IsNullOrEmpty(Source);
    public string Source { get; private set; }
    public bool HideUI { get; private set; }

    public ArgParser()
    {
        var args = System.Environment.GetCommandLineArgs();
        for (var i = 1; i < args.Length; i++)
            if (i < args.Length - 1 && args[i] == "--source")
                Source = args[++i];
            else if (args[i] == "--hide-ui")
                HideUI = true;
    }
}

} // namespace Nsm
