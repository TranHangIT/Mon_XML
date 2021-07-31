<?xml version="1.0" encoding="ISO-8859-1"?>

<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="catalog">
        <html>
            <title>Vi du</title>
            <body>
                <h2>My CD Collection</h2>
                <font color="red"> <xsl:value-of select="/catalog/cd/title"/> </font> -
                <font color="green"><xsl:value-of select="/catalog/cd/artist"/></font> -
                <font color="blue"> <xsl:value-of select="/catalog/cd/price"/></font> -
                <font color="magenta"><xsl:value-of select="/catalog/cd/year"/> </font>
            </body>
        </html>
    </xsl:template>
 
</xsl:stylesheet>