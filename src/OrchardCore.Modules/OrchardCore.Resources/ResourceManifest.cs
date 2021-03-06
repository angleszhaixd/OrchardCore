using OrchardCore.ResourceManagement;

namespace OrchardCore.Resources
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineScript("jQuery")
                .SetCdn("https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js")
                .SetVersion("1.12.4")
                ;

            manifest
                .DefineScript("jQuery")
                .SetCdn("https://ajax.googleapis.com/ajax/libs/jquery/2.2.4/jquery.min.js")
                .SetVersion("2.2.4")
                ;

            manifest
                .DefineScript("jQuery")
                .SetCdn("https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js")
                .SetVersion("3.2.1")
                ;

            manifest
                .DefineScript("jQuery.slim")
                .SetCdn("https://code.jquery.com/jquery-3.2.1.slim.min.js", "https://code.jquery.com/jquery-3.2.1.slim.js")
                .SetCdnIntegrity("sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN")
                .SetVersion("3.2.1")
                ;

            manifest
                .DefineScript("jQuery-ui")
                .SetDependencies("jQuery")
                .SetUrl("/OrchardCore.Resources/Scripts/jquery-ui.min.js", "/OrchardCore.Resources/Scripts/jquery-ui.js")
                .SetCdn("https://code.jquery.com/ui/1.12.1/jquery-ui.min.js", "https://code.jquery.com/ui/1.12.1/jquery-ui.js")
                .SetVersion("1.12.1")
                ;

            manifest
                .DefineStyle("jQuery-ui")
                .SetUrl("/OrchardCore.Resources/Styles/jquery-ui.min.css", "/OrchardCore.Resources/Styles/jquery-ui.css")
                .SetCdn("https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.min.css", "https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css")
                .SetVersion("1.12.1")
                ;

            manifest
                .DefineScript("bootstrap")
                .SetDependencies("jQuery")
                .SetCdn("https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js")
                .SetCdnIntegrity("sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa")
                .SetVersion("3.3.7")
                ;

            manifest
                .DefineStyle("bootstrap")
                .SetCdn("https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css")
                .SetCdnIntegrity("sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u")
                .SetVersion("3.3.7")
                ;

            manifest
                .DefineStyle("bootstrap-theme")
                .SetCdn("https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css")
                .SetCdnIntegrity("sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp")
                .SetVersion("3.3.7")
                ;

            manifest
                .DefineScript("popper")
                .SetUrl("/OrchardCore.Resources/Scripts/popper.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js", "https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.js")
                .SetCdnIntegrity("sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh")
                .SetVersion("1.12.3")
                ;

            manifest
                .DefineScript("bootstrap")
                .SetDependencies("jQuery", "popper")
                .SetUrl("/OrchardCore.Resources/Scripts/bootstrap.min.js", "/OrchardCore.Resources/Scripts/bootstrap.js")
                .SetCdn("https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js")
                .SetCdnIntegrity("sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ")
                .SetVersion("4.0.0")
                ;

            manifest
                .DefineStyle("bootstrap")
                .SetUrl("/OrchardCore.Resources/Styles/bootstrap.min.css", "/OrchardCore.Resources/Styles/bootstrap.css")
                .SetCdn("https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css")
                .SetCdnIntegrity("sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb")
                .SetVersion("4.0.0")
                ;

            manifest
                .DefineStyle("font-awesome")
                .SetUrl("/OrchardCore.Resources/Styles/font-awesome.min.css", "/OrchardCore.Resources/Styles/font-awesome.css")
                .SetCdn("https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css")
                .SetCdnIntegrity("sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN")
                .SetVersion("4.7.0")
                ;
        }
    }
}
