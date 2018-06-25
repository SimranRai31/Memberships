Create table tblSection(    
    Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,    
    Title nvarchar(255) NOT NULL,      
) 

Create table tblPart(    
    Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,    
    Title nvarchar(255) NOT NULL,      
) 

Create table tblItemType(    
    Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,    
    Title nvarchar(255) NOT NULL,      
)

Create table tblItem(    
    Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,    
    Title nvarchar(255) NOT NULL, 
	Itemdescription nvarchar(2048) ,
	ItemUrl nvarchar(1024),
	ImageUrl nvarchar(1024),
	HTML nvarchar(255),
	WaitDays int,
	HTMLShort nvarchar(255),
	ProductId int,
	ItemTypeId int,
	SectionId int,
	PartId int,
	IsFree int,	
)

Create table tblProduct(    
    Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,    
    Title nvarchar(255) NOT NULL, 
	Itemdescription nvarchar(2048),
	ImageUrl nvarchar(1024),
	ProductLinkTextId int,
	ProductTypeId int,	
)

Create table tblProductType(    
    Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,    
    Title nvarchar(25) NOT NULL,      
)