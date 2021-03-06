﻿using FMS3.DataAccess;
using FMS3.DataAccess.Interfaces;
using FMS3.DataAccess.Queries;
using FMS3.Services;
using FMS3.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FMS3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddRazorOptions(o =>
                {
                    o.ViewLocationFormats.Add("Views/Match/{0}.cshtml");
                });

            services.AddTransient<IDataAccessor, DataAccessor>();
            services.AddTransient<IQuery, Query>();

            services.AddTransient<IMatchQuery, MatchQuery>();
            services.AddTransient<IMatchGoalQuery, MatchGoalQuery>();
            services.AddTransient<IGameDetailsQuery, GameDetailsQuery>();
            services.AddTransient<INewsQuery, NewsQuery>();
            services.AddTransient<IPlayerQuery, PlayerQuery>();
            services.AddTransient<IPlayerAttributeQuery, PlayerAttributeQuery>();
            services.AddTransient<IPlayerStatsQuery, PlayerStatsQuery>();
            services.AddTransient<ISeasonQuery, SeasonQuery>();
            services.AddTransient<ITeamQuery, TeamQuery>();
            services.AddTransient<ITeamSeasonQuery, TeamSeasonQuery>();
            services.AddTransient<IMatchGoalQuery, MatchGoalQuery>();
            services.AddTransient<IMatchEventQuery, MatchEventQuery>();

            services.AddTransient<IPlayerCreatorService, PlayerCreatorService>();
            services.AddTransient<IPlayerService, PlayerService>();
            services.AddTransient<IPlayerAttributeService, PlayerAttributeService>();
            services.AddTransient<IPlayerStatsService, PlayerStatsService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<INewsService, NewsService>();
            services.AddTransient<ITeamSeasonService, TeamSeasonService>();
            services.AddTransient<IGameDetailsService, GameDetailsService>();
            services.AddTransient<IFixtureGenerator, FixtureGenerator>();
            services.AddTransient<ISeasonService, SeasonService>();
            services.AddTransient<IMatchService, MatchService>();
            services.AddTransient<IMatchGoalService, MatchGoalService>();
            services.AddTransient<IMatchEventService, MatchEventService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
