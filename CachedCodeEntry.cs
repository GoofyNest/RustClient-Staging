internal sealed class CachedCodeEntry // TypeDefIndex: 2601
{	internal string _key; // 0x10
	internal RegexCode _code; // 0x18
	internal Hashtable _caps; // 0x20
	internal Hashtable _capnames; // 0x28
	internal string[] _capslist; // 0x30
	internal int _capsize; // 0x38
	internal RegexRunnerFactory _factory; // 0x40
	internal ExclusiveReference _runnerref; // 0x48
	internal SharedReference _replref; // 0x50


	internal void .ctor(string key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, SharedReference repl) { }

}

