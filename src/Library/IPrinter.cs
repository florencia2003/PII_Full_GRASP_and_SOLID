
namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
        //Por DIP
         void PrintRecipe(IRecipeContent recipe);
    }
}