public enum ComputeBufferType // TypeDefIndex: 3413
{	public int value__; // 0x0
	public const ComputeBufferType Default = 0;
	public const ComputeBufferType Raw = 1;
	public const ComputeBufferType Append = 2;
	public const ComputeBufferType Counter = 4;
	public const ComputeBufferType Constant = 8;
	public const ComputeBufferType Structured = 16;
	[ObsoleteAttribute] // RVA: 0x95EF0 Offset: 0x952F0 VA: 0x180095EF0
	public const ComputeBufferType DrawIndirect = 256;
	public const ComputeBufferType IndirectArguments = 256;
	[ObsoleteAttribute] // RVA: 0x96000 Offset: 0x95400 VA: 0x180096000
	public const ComputeBufferType GPUMemory = 512;

}

