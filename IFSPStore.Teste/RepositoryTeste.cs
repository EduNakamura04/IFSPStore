using IFSPStore.Repository.Context;
using IFSPStoreDomain.Entities;
using System.Text.Json;

namespace IFSPStore.Teste
{
    [TestClass]
    public sealed class RepositoryTeste()
    {
        [TestMethod]
        public void TestCategory()
        {
            using (var context = new IFSPStoreContext())
            {
                Console.WriteLine("Connected!");

                var category1 = new Category(1, "Carnes");
                var category2 = new Category(2, "Bebidas");
                var category3 = new Category(3, "Doces");

                context.Categories.Add(category1);
                context.Categories.Add(category2);
                context.Categories.Add(category3);
                context.SaveChanges();
                Console.WriteLine("Insert done!");
            }
            using (var context = new IFSPStoreContext())
            {
                foreach (var cat in context.Categories)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));
                }
                Console.WriteLine("List done!");
            }
        }
    }
}
