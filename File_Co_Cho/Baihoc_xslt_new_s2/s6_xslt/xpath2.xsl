<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:template match="/">
        <xsl:text>Total cost of books =</xsl:text>
        <xsl:value-of select="sum(//book/price)"/>
       
        <p>Total number of books =
            <xsl:value-of select="count(//book)"/>
        </p>
    </xsl:template>
</xsl:stylesheet>