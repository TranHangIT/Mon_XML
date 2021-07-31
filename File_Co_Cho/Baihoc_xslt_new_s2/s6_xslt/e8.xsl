<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

    <xsl:template match="/">
        <html>
            <head>
                <style>
                    table{
                    border-collapse: collapse;
                    }
                    td{
                    padding: 5px;
                    }
                </style>
            </head>
            <body>
                <h2>My CD Collection</h2>
                <table border="1">
                    <tr bgcolor="greenyellow">
                        <th>No</th>
                        <th>Song's Name</th>
                        <th>Artist</th>
                        <th>Price</th>
                        <th>Year</th>
                    </tr>
                    <xsl:for-each select="catalog/cd">
                        <xsl:sort select="price" data-type="number"/>
                        <tr>
                            <td>
                                <xsl:number value="position()" format="1."/>
                            </td>
                            <td>
                                <xsl:value-of select="title"/>
                            </td>
                            
                            <xsl:choose>
                                <xsl:when test="price > 10">
                                    <td bgcolor="pink">
                                        <xsl:value-of select="artist"/>
                                    </td>
                                </xsl:when>
                                <xsl:when test="price &gt; 9">
                                    <td bgcolor="lightblue">
                                        <xsl:value-of select="artist"/>
                                    </td>
                                </xsl:when>
                                <xsl:otherwise>
                                    <td bgcolor="lavender">
                                        <xsl:value-of select="artist"/>
                                    </td>
                                </xsl:otherwise> 
                            </xsl:choose>                                                       
                            <td>
                                <xsl:value-of select="price"/>
                            </td>
                            <td>
                                <xsl:value-of select="year"/>
                            </td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>