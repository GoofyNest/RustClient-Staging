public enum ComputeBufferType // TypeDefIndex: 3413
{	public int value__; // 0x0
	public const ComputeBufferType Default = 0;
	public const ComputeBufferType Raw = 1;
	public const ComputeBufferType Append = 2;
	public const ComputeBufferType Counter = 4;
	public const ComputeBufferType Constant = 8;
	public const ComputeBufferType Structured = 16;
	[ObsoleteAttribute] // RVA: 0x95E70 Offset: 0x95270 VA: 0x180095E70
	public const ComputeBufferType DrawIndirect = 256;
	public const ComputeBufferType IndirectArguments = 256;
	[ObsoleteAttribute] // RVA: 0x95F80 Offset: 0x95380 VA: 0x180095F80
	public const ComputeBufferType GPUMemory = 512;

}

