public abstract class SHA1 : HashAlgorithm // TypeDefIndex: 984
{	// Methods

	// RVA: 0x17BE9B0 Offset: 0x17BCFB0 VA: 0x1817BE9B0
	protected void .ctor() { }

	// RVA: 0x17BE890 Offset: 0x17BCE90 VA: 0x1817BE890
	public static SHA1 Create() { }

}

public class SHA1Managed : SHA1 // TypeDefIndex: 985
{	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA1; // 0x38
	private uint[] _expandedBuffer; // 0x40

	// Methods

	// RVA: 0x17BE790 Offset: 0x17BCD90 VA: 0x1817BE790
	public void .ctor() { }

	// RVA: 0x17BDC80 Offset: 0x17BC280 VA: 0x1817BDC80 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17BDC60 Offset: 0x17BC260 VA: 0x1817BDC60 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BDC70 Offset: 0x17BC270 VA: 0x1817BDC70 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1706B00 Offset: 0x1705100 VA: 0x181706B00
	private void InitializeState() { }

	// RVA: 0x17BE620 Offset: 0x17BCC20 VA: 0x1817BE620
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17BE2C0 Offset: 0x17BC8C0 VA: 0x1817BE2C0
	private byte[] _EndHash() { }

	// RVA: 0x17BDD10 Offset: 0x17BC310 VA: 0x1817BDD10
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x17BDCD0 Offset: 0x17BC2D0 VA: 0x1817BDCD0
	private static void SHAExpand(uint* x) { }

}

public abstract class SHA256 : HashAlgorithm // TypeDefIndex: 986
{	// Methods

	// RVA: 0x17BFD50 Offset: 0x17BE350 VA: 0x1817BFD50
	protected void .ctor() { }

	// RVA: 0x17BFC20 Offset: 0x17BE220 VA: 0x1817BFC20
	public static SHA256 Create() { }

}

public class SHA256Managed : SHA256 // TypeDefIndex: 987
{	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x17BFA40 Offset: 0x17BE040 VA: 0x1817BFA40
	public void .ctor() { }

	// RVA: 0x17BEB80 Offset: 0x17BD180 VA: 0x1817BEB80 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17BE9E0 Offset: 0x17BCFE0 VA: 0x1817BE9E0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BE9F0 Offset: 0x17BCFF0 VA: 0x1817BE9F0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17BEA00 Offset: 0x17BD000 VA: 0x1817BEA00
	private void InitializeState() { }

	// RVA: 0x17BF800 Offset: 0x17BDE00 VA: 0x1817BF800
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17BF4A0 Offset: 0x17BDAA0 VA: 0x1817BF4A0
	private byte[] _EndHash() { }

	// RVA: 0x17BECB0 Offset: 0x17BD2B0 VA: 0x1817BECB0
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x17BEBE0 Offset: 0x17BD1E0 VA: 0x1817BEBE0
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x17BE9D0 Offset: 0x17BCFD0 VA: 0x1817BE9D0
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x17BEBD0 Offset: 0x17BD1D0 VA: 0x1817BEBD0
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x17BFB40 Offset: 0x17BE140 VA: 0x1817BFB40
	private static uint sigma_0(uint x) { }

	// RVA: 0x17BFBB0 Offset: 0x17BE1B0 VA: 0x1817BFBB0
	private static uint sigma_1(uint x) { }

	// RVA: 0x17BF3C0 Offset: 0x17BD9C0 VA: 0x1817BF3C0
	private static uint Sigma_0(uint x) { }

	// RVA: 0x17BF430 Offset: 0x17BDA30 VA: 0x1817BF430
	private static uint Sigma_1(uint x) { }

	// RVA: 0x17BEC00 Offset: 0x17BD200 VA: 0x1817BEC00
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x17BF9D0 Offset: 0x17BDFD0 VA: 0x1817BF9D0
	private static void .cctor() { }

}

public abstract class SHA384 : HashAlgorithm // TypeDefIndex: 988
{	// Methods

	// RVA: 0x17C1120 Offset: 0x17BF720 VA: 0x1817C1120
	protected void .ctor() { }

	// RVA: 0x17C0FF0 Offset: 0x17BF5F0 VA: 0x1817C0FF0
	public static SHA384 Create() { }

}

public class SHA384Managed : SHA384 // TypeDefIndex: 989
{	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA384; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x17C0DF0 Offset: 0x17BF3F0 VA: 0x1817C0DF0
	public void .ctor() { }

	// RVA: 0x17BFF60 Offset: 0x17BE560 VA: 0x1817BFF60 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17BFD80 Offset: 0x17BE380 VA: 0x1817BFD80 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BFD90 Offset: 0x17BE390 VA: 0x1817BFD90 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17BFDA0 Offset: 0x17BE3A0 VA: 0x1817BFDA0
	private void InitializeState() { }

	// RVA: 0x17C0BB0 Offset: 0x17BF1B0 VA: 0x1817C0BB0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17C0970 Offset: 0x17BEF70 VA: 0x1817C0970
	private byte[] _EndHash() { }

	// RVA: 0x17C0090 Offset: 0x17BE690 VA: 0x1817C0090
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x17BFFC0 Offset: 0x17BE5C0 VA: 0x1817BFFC0
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x17BFD70 Offset: 0x17BE370 VA: 0x1817BFD70
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x17BFFB0 Offset: 0x17BE5B0 VA: 0x1817BFFB0
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x17C0870 Offset: 0x17BEE70 VA: 0x1817C0870
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x17C08F0 Offset: 0x17BEEF0 VA: 0x1817C08F0
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x17C0EF0 Offset: 0x17BF4F0 VA: 0x1817C0EF0
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x17C0F70 Offset: 0x17BF570 VA: 0x1817C0F70
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x17BFFE0 Offset: 0x17BE5E0 VA: 0x1817BFFE0
	private static void SHA384Expand(ulong* x) { }

	// RVA: 0x17C0D80 Offset: 0x17BF380 VA: 0x1817C0D80
	private static void .cctor() { }

}

public abstract class SHA512 : HashAlgorithm // TypeDefIndex: 990
{	// Methods

	// RVA: 0x17C24B0 Offset: 0x17C0AB0 VA: 0x1817C24B0
	protected void .ctor() { }

	// RVA: 0x17C2380 Offset: 0x17C0980 VA: 0x1817C2380
	public static SHA512 Create() { }

}

public class SHA512Managed : SHA512 // TypeDefIndex: 991
{	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x17C2180 Offset: 0x17C0780 VA: 0x1817C2180
	public void .ctor() { }

	// RVA: 0x17C1320 Offset: 0x17BF920 VA: 0x1817C1320 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17C1140 Offset: 0x17BF740 VA: 0x1817C1140 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17C1150 Offset: 0x17BF750 VA: 0x1817C1150 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17C1160 Offset: 0x17BF760 VA: 0x1817C1160
	private void InitializeState() { }

	// RVA: 0x17C1F40 Offset: 0x17C0540 VA: 0x1817C1F40
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17C1D00 Offset: 0x17C0300 VA: 0x1817C1D00
	private byte[] _EndHash() { }

	// RVA: 0x17C1420 Offset: 0x17BFA20 VA: 0x1817C1420
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x17BFFC0 Offset: 0x17BE5C0 VA: 0x1817BFFC0
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x17BFD70 Offset: 0x17BE370 VA: 0x1817BFD70
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x17BFFB0 Offset: 0x17BE5B0 VA: 0x1817BFFB0
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x17C1C00 Offset: 0x17C0200 VA: 0x1817C1C00
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x17C1C80 Offset: 0x17C0280 VA: 0x1817C1C80
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x17C2280 Offset: 0x17C0880 VA: 0x1817C2280
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x17C2300 Offset: 0x17C0900 VA: 0x1817C2300
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x17C1370 Offset: 0x17BF970 VA: 0x1817C1370
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x17C2110 Offset: 0x17C0710 VA: 0x1817C2110
	private static void .cctor() { }

}

internal class SHA1Internal // TypeDefIndex: 1011
{	// Fields
	private uint[] _H; // 0x10
	private ulong count; // 0x18
	private byte[] _ProcessingBuffer; // 0x20
	private int _ProcessingBufferCount; // 0x28
	private uint[] buff; // 0x30

	// Methods

	// RVA: 0x17BDBC0 Offset: 0x17BC1C0 VA: 0x1817BDBC0
	public void .ctor() { }

	// RVA: 0x17BC2F0 Offset: 0x17BA8F0 VA: 0x1817BC2F0
	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BC410 Offset: 0x17BAA10 VA: 0x1817BC410
	public byte[] HashFinal() { }

	// RVA: 0x17BD0F0 Offset: 0x17BB6F0 VA: 0x1817BD0F0
	public void Initialize() { }

	// RVA: 0x17BD1D0 Offset: 0x17BB7D0 VA: 0x1817BD1D0
	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	// RVA: 0x17BC520 Offset: 0x17BAB20 VA: 0x1817BC520
	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	// RVA: 0x17BBD10 Offset: 0x17BA310 VA: 0x1817BBD10
	private static void FillBuff(uint[] buff) { }

	// RVA: 0x17BDA00 Offset: 0x17BC000 VA: 0x1817BDA00
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17BBBA0 Offset: 0x17BA1A0 VA: 0x1817BBBA0
	internal void AddLength(ulong length, byte[] buffer, int position) { }

}

public sealed class SHA1CryptoServiceProvider : SHA1 // TypeDefIndex: 1012
{	// Fields
	private SHA1Internal sha; // 0x28

	// Methods

	// RVA: 0x17BBAB0 Offset: 0x17BA0B0 VA: 0x1817BBAB0
	public void .ctor() { }

	// RVA: 0x17032F0 Offset: 0x17018F0 VA: 0x1817032F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17BB830 Offset: 0x17B9E30 VA: 0x1817BB830 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17BB840 Offset: 0x17B9E40 VA: 0x1817BB840 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BB970 Offset: 0x17B9F70 VA: 0x1817BB970 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17BBA90 Offset: 0x17BA090 VA: 0x1817BBA90 Slot: 16
	public override void Initialize() { }

}

