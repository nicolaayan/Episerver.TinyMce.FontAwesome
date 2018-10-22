# Episerver.TinyMce.FontAwesome

## Copy the entire Business > Components > TinyMceFontAwesome folder
Paste this to your Episerver project. This contains all the static files (JS, CSS, font files) required for the Fontawesome to work.

## Setup TinyMCE Initialisation
1. If you have an existing Initialization.cs class for your TinyMCE, open it and add the lines from the Business > Initialization > ExtendedTinyMceInitialization.cs. If you don't, copy this entire class to your project.
2. Verify the paths are correct:
- ExtendedTinyMceInitialization.cs - AddExternalPlugin("icons", "/Business/Components/TinyMceFontAwesome/fontawesomeicons.js")
- ExtendedTinyMceInitialization.cs - ContentCss(new[]{ "/Business/Components/TinyMceFontAwesome/fontawesome.min.css" });

## On your _Root.cshtml, reference the fontawesome.min.css
You'll need to make sure you also reference the fontawesome CSS from your <head> section of your site HTML


