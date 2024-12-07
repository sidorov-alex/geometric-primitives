SELECT
	p."Name"
,	c."Name"
FROM
	"Product" p
LEFT JOIN
	"ProductCategory" pc on p."Id" = pc."ProductId"
LEFT JOIN
	"Category" c on pc."CategoryId" = c."Id"