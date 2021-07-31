<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html"/>

    <!-- TODO customize transformation rules 
         syntax recommendation http://www.w3.org/TR/xslt 
    -->
    <xsl:template match="/">
        <html>
            <head>
                <title>ex66.xsl</title>
                <h1>Danh sach CD</h1>
               
            </head>
            <body> 
                <table border="1">
                    <tr>
                         <th>No</th>
                        <th>Title</th>
                        <th>Artist</th>
                        <th>Country</th>
                        <th>Company</th>
                        <th>Price</th>
                    </tr>
                    <xsl:for-each select="catalog/cd">
                        <xsl:sort select="price" data-type="number" />
                        <tr>
                            <td>
                                <xsl:number format="1." value="position()"/>
                            </td>
                            <td> 
                                <xsl:value-of select="title"/>
                            </td>
                            <td>  
                                <xsl:value-of select="artist"/>
                            </td>
                            <td>  
                                <xsl:value-of select="country"/>
                            </td>
                            <td>  
                                <xsl:value-of select="company"/>
                            </td>
                            <td>   
                                <xsl:value-of select="price"/>
                            </td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>
