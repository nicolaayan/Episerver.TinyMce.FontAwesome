using EPiServer.Cms.TinyMce.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using YourLegalFriend.Content.Blocks;
using YourLegalFriend.Content.Blocks.Section;

namespace NicolaAyan.Business.Initialization
{
    [ModuleDependency(typeof(TinyMceInitialization))]
    public class ExtendedTinyMceInitialization : IConfigurableModule
    {
        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Services.Configure<TinyMceConfiguration>(config =>
            {
                // Use the default settings and extend
                config.Default()
					.AddExternalPlugin("icons", "/Business/Components/TinyMceFontAwesome/fontawesomeicons.js")
					// Feel free to mix the "icons" into an existing toolbar instead of using the below line
					.AppendToolbar("icons")
					.AddSetting("extended_valid_elements", "i[class], span")
					// Add your other TinyMce custom CSS below
					.ContentCss(new[]{ "/Business/Components/TinyMceFontAwesome/fontawesome.min.css" });

			});
        }
    }
}
