namespace TransportTycoon
{
    public interface IRoutingSource
    {
        Route FindRoute(Place currentLocation, Place destination);
    }
}
