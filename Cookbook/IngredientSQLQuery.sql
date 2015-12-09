select a.name from Ingredient a
INNER JOIN RecipeIngredient b on a.Id = b.IngredientID
WHERE b.RecipeID = 2;