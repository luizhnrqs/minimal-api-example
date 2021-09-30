namespace MinimalAPIExample
{
    public static class UseMockDadosExtension
    {
        public static void UseMockDados(
            this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<InMemoryDbContext>();
                Mock.Configurar(context);
            }            
        }
    }
}
