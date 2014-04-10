# Html2Article

.NETƽ̨�£�һ����Ч�Ĵ�Html����ȡ���ĵĹ��ߡ�  
������ȡ�����˻����ı��ܶȵ���ȡ�㷨��֧�ִ�ѹ����Html�ĵ�����ȡ���ģ�ÿ��ҳ��ƽ����ȡʱ��Ϊ30ms����ȷ����95%���ϡ�  
![Html2Article](http://stanzhai.github.com/images/project/Html2Article.png)

## Html2Article��ɫ

* ��ǩ�޹أ���ȡ���Ĳ�������ǩ��
* ֧�ִ�ѹ����html�ĵ�����ȡ�������ݣ�
* ֧�ִ���ǩ����ԭʼ���ģ�
* �����㷨������Ч��ƽ����ȡʱ����30ms���ҡ�

## ��������Ŀ֧��Html������ȡ

- **`PM> Install-Package Html2Article`**
- **���������ռ�`using StanSoft;`��**
- **�������´��룺**

```C#
// htmlΪ��Ҫ��ȡ��html�ı�
string html = "<html>....</html>";
// article��������Title(����)��PublishDate(��������)��Content(����)��ContentWithTags(����ǩ����)�ĸ�����
Article article = Html2Article.GetArticle(html);
```

## Html2Article��

- **Html2Article������ȡ���ĵĺ�����**
- **Html2Article����˵��**  
	* AppendMode���Ƿ�ʹ������׷��ģʽ��Ĭ��Ϊfalse������Ϊtrue�Ὣ���������������ı����ӵ����ġ�
	* Depth�����������ȣ�Ĭ��Ϊ5�������п�϶�ϴ���ҳ�������Ӵ�ֵ��  
	* LimitCount���ַ��޶��������������ı������ﵽ�޶�������Ϊ�����������ݣ�Ĭ��Ϊ180���ַ���  
	* GetArticle(string html)����Html�ı��л�ȡArticle��

## License

[Apache 2.0](http://www.apache.org/licenses/LICENSE-2.0)
