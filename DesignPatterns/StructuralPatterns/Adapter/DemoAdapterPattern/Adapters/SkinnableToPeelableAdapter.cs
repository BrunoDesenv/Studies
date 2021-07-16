using DemoAdapterPattern.Models;

namespace DemoAdapterPattern.Adapters
{
    internal class SkinnableToPeelableAdapter : IPeelable
    {
        private ISkinnable skinnable;

        public SkinnableToPeelableAdapter(ISkinnable skinnable)
        {
            this.skinnable = skinnable;
        }

        public void Peel()
        {
            skinnable.Skin();
        }
    }
}