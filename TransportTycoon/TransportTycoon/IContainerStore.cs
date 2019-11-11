namespace TransportTycoon
{
    public interface IContainerStore
    {
        RoutingInstructions LoadContainer();
        void UnloadContainer(Container container);
    }

    public class RoutingInstructions
    {
        public RoutingInstructions(Container container, Route route)
        {
            this.Container = container;
            this.Route = route;
        }

        public Container Container { get; }
        public Route Route { get; }
    }
}
