using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.GameContent;

namespace ACulinaryArtillery.GUI
{
    class GuiHandbookMixingMealRecipePage : GuiHandbookMealRecipePage
    {
        public GuiHandbookMixingMealRecipePage(ICoreClientAPI capi, CookingRecipe recipe, ItemStack[] allstacks, int slots = 6, bool isPie = false) : base(capi, recipe, allstacks, slots, isPie)
        {

        }


        public void oAddCookingDirections(ICoreClientAPI capi, List<RichTextComponentBase> components)
        {
            string directionsText = Lang.GetMatchingIfExists("aculinaryartillery:handbook-mixingrecipe-directionstext-" + Recipe.Code);


            directionsText ??= Lang.Get("aculinaryartillery:handbook-mixingrecipe-directionstext");

            components.Add(new ClearFloatTextComponent(capi, MediumPadding));
            components.AddRange(VtmlUtil.Richtextify(capi, Lang.Get("handbook-mealrecipe-directions", directionsText) + "\n", CairoFont.WhiteSmallText()));
        }
    }
}
