
namespace Transport.Entities.Engines
{
    public abstract class InternalСombustionEngine : Engine
    {
        public float Volume { get; set; }

        public InternalСombustionEngine() { }

        public InternalСombustionEngine(float volume)
        {
            if (volume < 0)
            {
                throw new System.Exception("The volume of engine can't be less than 0.");
            }
            Volume = volume;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Volume: {Volume}";
        }
    } 
}
