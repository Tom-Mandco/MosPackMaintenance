Select Distinct rSize.size_code        "Size_Code",
				rSize.size_description "Size_Description"
From	 shp_sizes_by_size_range sizeBySizeRange,
		 ref_size                rSize
Where    sizeBySizeRange.size_code = rSize.size_code
And		 sizeBySizeRange.size_range = @0
Order By rSize.size_code Asc