namespace ValveService.Data;
public class Seed
{
    public static async Task SeedValveCodes(ApplicationDbContext context)
        {
            if (await context.ValveCodes.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/Seed/ValveCodes.json");
            var emp = JsonSerializer.Deserialize<List<Valve_Code>>(userData);
            if(emp != null){
            foreach (var item in emp) { context.ValveCodes.Add(item); }
            await context.SaveChangesAsync();
            }

            if (await context.ValveSizes.AnyAsync()) return;

            var testData = await System.IO.File.ReadAllTextAsync("Data/Seed/ValveSizes.json");
            var testemp = JsonSerializer.Deserialize<List<Valve_Size>>(testData);
            if(testemp != null){
            foreach (var item in testemp) { context.ValveSizes.Add(item); }
            await context.SaveChangesAsync();
            }
        }
       
}