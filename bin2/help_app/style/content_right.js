var txtJson = {
    intro: ["&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;本程序提供多种影像数据的加载和显示功能，也提供了<b>矢量数据的加载和显示功能</b>。",
        "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;菜单栏上提供了一系列工具对数据进行操作，如<b>缩放、拖动、全图显示、卷帘、探针</b>等.。",
        "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;程序主界面左侧是<b>图层列表窗口</b>，加载进来的文件图层名称会显示在该列表中，右侧是<b>图层显示窗口</b>，加载进来的影像数据或者矢量数据会显示在该窗口中。",
        "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;程序主界面底部提供了算法执行进度条和图像相关信息的说明标签。",
        "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;程序核心数据处理功能有<b>遥感图像非监督分类，图像融合，面向对象分类</b>。",
        "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;非监督分类有三种方法，分别是<b>ISODATA分类、神经网络聚类以及K-Means分类</b>;",
        "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;图像融合采用的算法是<b>PCA融合</b>;",
        "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;面向对象分类模块提供了从影像<b>多尺度分割到面向对象分类</b>的\"一站式\"解决方案，这个模块也可以将影像多尺度分割功能分离出来，生成分割后的矢量图。"],
    load: ["&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;程序的菜单栏上提供了三个数据加载功能:",
        "<h1>【打开矢量数据】:</h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;加载指定目录的矢量文件；",
        "<h1>【打开栅格数据】:</h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;加载指定目录的栅格文件，包括tif，tiff，dat，bmp，jpg等格式;",
        "<h1>【打开科学数据集】:</h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;加载指定目录下格式为hdf和h5的科学数据集;",
        "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;数据处理的对话框中也提供了数据载入功能，这一部分将在第3节详述。"],
    listWindow: ["根据图层列表窗口中节点的不同，该窗口提供不同的上下文菜单，内置的Map节点提供<b>【激活地图】、【加载矢量数据】、【加载栅格数据】、【显示所有图层】、【隐藏所有图层】、【删除所有图层】</b>这几个功能。",
    "若加载的数据为栅格图层，将显示<b>【缩放至图层】、【删除图层】、【打开文件路径】、【属性】</b>上下文菜单，",
    "<b>【属性】</b>窗口将显示通用、源、栅格信息、栅格透明度、栅格渲染选项卡，可以在各选项卡下查看和设置相关信息。",
    "若加载的数据为矢量图层，将显示<b>【缩放至图层】、【删除图层】、【打开文件路径】、【标注要素】、【属性表】</b>上下文菜单:",
    "其中<b>【标注要素】</b>能够标注出每个矢量单元的重心，<b>【属性表】</b>窗口可以展示矢量文件的字段信息"],
    merge: ["&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>影像融合</b>用于将高分辨率的全色影像和低分辨率的多光谱融合在一起，从而提供既具有详细空间特征又具有详细光谱特征的影像。",
    "<h1>【PCA融合】</h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;窗口要求提供多光谱影像和高分辨率影像的文件目录，将多光谱影像加载进来之后，可以选择参与运算的波段",
    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;在设置影像重采样方法时，有三种选择，包括最近领域法，双线性插值法，三次卷积法。",
        "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;最后还需要设置输出影像的目录。算法执行完毕后，输出影像会自动加载到图层显示窗口中"],
    kMeans: ["<h1>①K-Means分类</h1>",
    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;K-means算法是很典型的基于距离的聚类算法，采用距离作为相似性的评价指标，即认为两个对象的距离越近，其相似度就越大。",
    "该算法认为簇是由距离靠近的对象组成的，因此把得到紧凑且独立的簇作为最终目标。",
    "打开<b>【K-Means】</b>窗口之后，选择处理的影像，然后选择参与运算的波段;",
    "在<b>【参数设置】</b>组合框中，设置预期的类数，最大迭代次数、终止阈值，最后设置输出影像的目录即可;",
    "在算法执行完毕后，输出结果会自动加载到图层显示窗口中。"],
    isodata: ["<h1>②ISODATA分类</h1>",
    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ISODATA算法是在K-Means算法的基础上，增加对聚类结果的“合并”和“分裂”两个操作，并设定算法运行控制参数的一种聚类算法。",
    "迭代次数会影响最终结果，迭代参数选择很重要。",
    "在打开<b>【ISODATA分类】</b>窗口之后，首先加载输入文件，选择参与运算的波段，在<b>【参数设置】</b>组合框中，设置预期类数、初始类数、最少像元数、",
    "最大迭代次数、最大标准差、最小中心距离、最大合并对数。该窗口打开后会显示程序给定的初始值，也可以自定义设置，最后设置输出影像的目录即可。",
    "在算法执行完毕后，输出结果会自动加载到图层显示窗口中。"],
    neural: ["<h1>③神经网络聚类</h1>",
    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;神经网络聚类算法假设在输入对象中存在一些拓扑结构或顺序，可以实现从输入空间(n维)到输出平面(2维)的降维映射，其映射具有",
    "拓扑特征保持性质,与实际的大脑处理有很强的理论联系。",
    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;在打开<b>【神经网路聚类】</b>窗口之后，首先加载输入文件，然后选择参与运算的波段，在<b>【参数设置】</b>组合框中，设置分类类别，有两种网络可供选择:",
    "交互传播网络和自组织特征映射网络。然后设置分类数，设置窗口大小，有1*1，3*3，5*5三种窗口，设置迭代次数以及收敛率，该窗口打开后会显示",
    "程序给定的初始值，也可以自定义设置，最后设置输出影像的目录即可。",
    "在算法执行完毕后，输出结果会自动加载到图层显示窗口中。"],
    objectClassify: ["<h1>面向对象分类</h1>",
        "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;影像面向对象分类包括<b>影像分割，选择样本，计算样本特征，进行分类</b>等过程，这些算法所需要的参数，数据都打包在一个规则集文件中，",
    "因此该程序模块只需要加载影像文件和规则集文件就可以进行分割和分类。",
    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;在进行分类时，首先加载待分类的影像，然后加载分类的规则集文件，点击窗口左上的<b>【分类信息设置】</b>菜单;",
    "打开对话框，查看分类信息，设置类别颜色，设置输出文件的路径，然后点击<b>【确定】</b>，最后点击<b>【执行算法】</b>，等待程序运行完成。",
    "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;在进行分割时，首先加载待分类的影像，然后加载分割的规则集文件，点击窗口左上的<b>【多尺度分割参数设置】</b>菜单",
    "打开对话框，点击<b>【显示初始值】</b>，可以查看规则集中的多尺度分割参数，也可以对这些参数进行自定义设置。"],
    notice: ["&nbsp;&nbsp;&nbsp;1、将程序主窗口缩小后，算法进度条将无法正确显示，可能无法查看算法执行的进度信息。因此，在执行算法时，应将主窗口最大化显示。",
        "&nbsp;&nbsp;&nbsp;2、在使用面向对象分类模块时，应将图层显示列表中已加载的文件清空。",
        "&nbsp;&nbsp;&nbsp;3、面向对象分类模块的算法计算量较大，处理较大影像时，可能需要几十分钟甚至更长时间。"]
};
function addText(obj, desObj){
    switch (obj){
        case "intro":
        case "notice":
        case "load":
        case "listWindow":
        case "merge":
        case "kMeans":
        case "isodata":
        case "neural":
        case "objectClassify":
            for (var i = 0;i<txtJson[obj].length;i++){
                var oP = document.createElement('p');
                oP.innerHTML = txtJson[obj][i];
                desObj.appendChild(oP);
            }
            break;
    }
}

var aSrcImg = ["style/right.png", "style/down.png"];
function transformIcon(parent, objImg, obj){
    $(parent).click(function () {
        var srcImg = $(objImg).attr("src");
        if (srcImg == aSrcImg[0]){
            $(objImg).attr("src", aSrcImg[1]);
        }
        else {
            $(objImg).attr("src", aSrcImg[0]);
        }
        $(obj).toggle(500);
    });
}