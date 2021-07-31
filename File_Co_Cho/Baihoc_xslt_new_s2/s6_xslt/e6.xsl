<?xml version="1.0" encoding="ISO-8859-1"?>
<!-- xem file lophoc.xsl ap dung xsl:apply-templates 
de khong can su dung vong lap for -->
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html"/>
    <xsl:template match="/">
        <html>
            <body>
                <h2>My CD Collection</h2>
                <table border="1">
                    <tr>
                        <th>thu thu</th>
                        <th>thu thu</th>
                        <th>thu thu</th>
                        <th>thu thu</th>
                        <th>thu thu</th>
                    </tr>
                    <xsl:for-each select="catalog/cd">
                        <xsl:sort select="price" data-type="number"/> 
                        <tr>
                            <!-- To sort the output, simply add an <xsl:sort> element inside the <xsl:for-each> element -->
                            <td>      
                               
                                <xsl:number value="position()" format="1." />                    
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