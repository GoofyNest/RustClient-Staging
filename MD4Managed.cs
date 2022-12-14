internal class MD4Managed : MD4 // TypeDefIndex: 69
{
	private uint[] state;
	private byte[] buffer;
	private uint[] count;
	private uint[] x;
	private byte[] digest;


	public void .ctor() { }

	public override void Initialize() { }

	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	private byte[] Padding(int nLength) { }

	private uint F(uint x, uint y, uint z) { }

	private uint G(uint x, uint y, uint z) { }

	private uint H(uint x, uint y, uint z) { }

	private uint ROL(uint x, byte n) { }

	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	private void Encode(byte[] output, uint[] input) { }

	private void Decode(uint[] output, byte[] input, int index) { }

	private void MD4Transform(uint[] state, byte[] block, int index) { }

}

public class MD4Managed : MD4 // TypeDefIndex: 1756
{
	private uint[] state;
	private byte[] buffer;
	private uint[] count;
	private uint[] x;
	private byte[] digest;


	public void .ctor() { }

	public override void Initialize() { }

	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	private byte[] Padding(int nLength) { }

	private uint F(uint x, uint y, uint z) { }

	private uint G(uint x, uint y, uint z) { }

	private uint H(uint x, uint y, uint z) { }

	private uint ROL(uint x, byte n) { }

	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	private void Encode(byte[] output, uint[] input) { }

	private void Decode(uint[] output, byte[] input, int index) { }

	private void MD4Transform(uint[] state, byte[] block, int index) { }

}

