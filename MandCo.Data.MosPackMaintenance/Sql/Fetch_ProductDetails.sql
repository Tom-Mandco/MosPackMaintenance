Select Unique(packMatch.product_number) "Product_Number",
              product.product_description "Product_Description"
From  war_hir_pack_match    packMatch,
      ref_product       product
Where packMatch.pack_id = @0
And   packMatch.product_number = product.product_number
Order by packMatch.product_number Asc