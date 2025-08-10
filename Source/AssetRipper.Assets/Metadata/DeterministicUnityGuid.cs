namespace AssetRipper.Assets.Metadata;

public static class DeterministicUnityGuid
{
	private static readonly Random rand = new(163245617);
	
	public static UnityGuid New()
	{
		byte[] guid = new byte[16];
		rand.NextBytes(guid);
		return new UnityGuid(guid);
	}
}
