using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class questionConfig : IEntityTypeConfiguration<Question>
    {
        public void Configure ( EntityTypeBuilder<Question> builder )
        {
            builder.ToTable("Questions");
            builder.HasKey(x => x.Id);

            builder.HasData(
    new { Id = 1, question = "ÅÒÇí ÃÈíÚ ÚÑÈíÊí¿", Response = "ÓÌá ÍÓÇÈ Úáì ÇáãäÕÉ¡ æÑæÍ áŞÓã 'ÈíÚ ÓíÇÑÉ'¡ æÇãáÃ ÇáÈíÇäÇÊ ÇáãØáæÈÉ æÇÑİÚ ÕæÑ ááÚÑÈíÉ." },
    new { Id = 2, question = "åá áÇÒã ÃßÔİ Úáì ÇáÚÑÈíÉ ŞÈá ÇáÈíÚ¿", Response = "ãÔ ÅÌÈÇÑí¡ áßä ÇáßÔİ ÈíÏí ãÕÏÇŞíÉ ÃÚáì æÈíÓÇÚÏ İí ÇáÈíÚ ÃÓÑÚ." },
    new { Id = 3, question = "İíå ÚãæáÉ Úáì ÇáÈíÚ¿", Response = "Ãíæå¡ ÇáãäÕÉ ÈÊÇÎÏ ÚãæáÉ ÈÓíØÉ ÈÚÏ ÅÊãÇã ÚãáíÉ ÇáÈíÚ ÈäÌÇÍ." },
    new { Id = 4, question = "ÅÒÇí ÃÃÌÑ ÚÑÈíÉ¿", Response = "ÇÏÎá Úáì ŞÓã 'ÊÃÌíÑ ÇáÓíÇÑÇÊ'¡ ÇÎÊÇÑ ÇáÚÑÈíÉ æÇáÊÇÑíÎ æÇÖÛØ ÍÌÒ." },
    new { Id = 5, question = "åá İíå ÊÃãíä Úáì ÇáÚÑÈíÇÊ¿", Response = "Ãíæå¡ ßá ÇáÚÑÈíÇÊ ÇáãÄÌÑÉ Èíßæä ÚáíåÇ ÊÃãíä ÔÇãá Øæá İÊÑÉ ÇáÅíÌÇÑ." },
    new { Id = 6, question = "åá ÃŞÏÑ ÃÑÌøÚ ÇáÚÑÈíÉ ŞÈá ÇáãÚÇÏ¿", Response = "Ãíæå¡ ÈÓ ããßä íÊÎÕã ÑÓæã ÍÓÈ ÓíÇÓÉ ÇáÅáÛÇÁ ÇáÎÇÕÉ ÈÇáÚÑÈíÉ." },
    new { Id = 7, question = "åá ÃŞÏÑ ÃØáÈ ÕíÇäÉ ááÚÑÈíÉ¿", Response = "Ãíæå¡ ãä ÎáÇá ŞÓã 'ÇáÕíÇäÉ' ÊŞÏÑ ÊÎÊÇÑ äæÚ ÇáÎÏãÉ æÊÍÌÒ ãÚÇÏ." },
    new { Id = 8, question = "åá İíå ÎÕæãÇÊ Úáì ÛÓíá ÇáÚÑÈíÉ¿", Response = "Ãíæå¡ ÊÇÈÚ ÇáÚÑæÖ İí ÇáÕİÍÉ ÇáÑÆíÓíÉ Ãæ İí ÇáÅÔÚÇÑÇÊ." },
    new { Id = 9, question = "åá ÇáæäÔ ÈíÔÊÛá İí ßá ãßÇä¿", Response = "Ãíæå¡ ÈäÛØí ÃÛáÈ ÇáãÍÇİÙÇÊ¡ æÈäÊæÓÚ ÈÔßá ãÓÊãÑ." },
    new { Id = 10, question = "åá İíå æÙíİÉ ÓæÇŞ ãÊÇÍÉ¿", Response = "Ãíæå¡ ŞÏã Úáì æÙíİÉ ãä ÎáÇá ÕİÍÉ 'ÇáæÙÇÆİ' æÓÌá ÈíÇäÇÊß." },
    new { Id = 11, question = "How can I sell my car?", Response = "Create an account on the platform, go to the 'Sell Car' section, fill in the required details, and upload photos of your car." },
    new { Id = 12, question = "Do I need to inspect the car before selling?", Response = "It's not mandatory, but inspection increases credibility and helps you sell faster." },
    new { Id = 13, question = "Is there a commission on selling?", Response = "Yes, the platform takes a small commission after the sale is completed." },
    new { Id = 14, question = "How can I rent a car?", Response = "Go to the 'Car Rental' section, choose the car and date, then click Book." },
    new { Id = 15, question = "Is insurance included with rental cars?", Response = "Yes, all rental cars come with full insurance during the rental period." },
    new { Id = 16, question = "Can I return the car earlier than scheduled?", Response = "Yes, but there might be a cancellation fee depending on the car's policy." },
    new { Id = 17, question = "Can I request car maintenance?", Response = "Yes, from the 'Car Maintenance' section you can select the service type and book an appointment." },
    new { Id = 18, question = "Are there discounts on car wash services?", Response = "Yes, keep an eye on offers on the homepage or through notifications." },
    new { Id = 19, question = "Does the towing service cover all areas?", Response = "Yes, we cover most regions and we are continuously expanding." },
    new { Id = 20, question = "Are there any driver job openings?", Response = "Yes, you can apply for driver positions from the 'Jobs' page and submit your details." },
    new { Id = 21, question = "ßíİ íãßääí ÈíÚ ÓíÇÑÊí¿", Response = "Şã ÈÅäÔÇÁ ÍÓÇÈ Úáì ÇáãäÕÉ¡ Ëã ÇäÊŞá Åáì ŞÓã 'ÈíÚ ÓíÇÑÉ'¡ æÇãáÃ ÇáÈíÇäÇÊ ÇáãØáæÈÉ æÇÑİÚ ÕæÑ ÇáÓíÇÑÉ." },
    new { Id = 22, question = "åá íÌÈ İÍÕ ÇáÓíÇÑÉ ŞÈá ÈíÚåÇ¿", Response = "ÇáİÍÕ áíÓ ÅáÒÇãíÇğ¡ æáßäå íÒíÏ ãä ãÕÏÇŞíÉ ÇáÅÚáÇä æíÓÇÚÏ İí ÈíÚ ÇáÓíÇÑÉ ÈÔßá ÃÓÑÚ." },
    new { Id = 23, question = "åá ÊæÌÏ ÚãæáÉ Úáì ÚãáíÉ ÇáÈíÚ¿", Response = "äÚã¡ ÇáãäÕÉ ÊÍÕá Úáì ÚãæáÉ ÈÓíØÉ ÈÚÏ ÅÊãÇã ÚãáíÉ ÇáÈíÚ ÈäÌÇÍ." },
    new { Id = 24, question = "ßíİ íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ¿", Response = "ÇäÊŞá Åáì ŞÓã 'ÊÃÌíÑ ÇáÓíÇÑÇÊ'¡ æÇÎÊÑ ÇáÓíÇÑÉ æÇáÊÇÑíÎ¡ Ëã ÇÖÛØ Úáì ÒÑ ÇáÍÌÒ." },
    new { Id = 25, question = "åá íÔãá ÊÃÌíÑ ÇáÓíÇÑÇÊ ÇáÊÃãíä¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ÇáãÄÌÑÉ ÊÔãá ÊÃãíäÇğ ÔÇãáÇğ ØæÇá ãÏÉ ÇáÅíÌÇÑ." },
    new { Id = 26, question = "åá íãßääí ÅÚÇÏÉ ÇáÓíÇÑÉ ŞÈá ÇáãæÚÏ ÇáãÍÏÏ¿", Response = "äÚã¡ æáßä ŞÏ íÊã ÎÕã ÑÓæã ÍÓÈ ÓíÇÓÉ ÇáÅáÛÇÁ ÇáÎÇÕÉ ÈÇáÓíÇÑÉ." },
    new { Id = 27, question = "åá íãßääí ØáÈ ÎÏãÉ ÕíÇäÉ ááÓíÇÑÉ¿", Response = "äÚã¡ íãßäß ãä ÎáÇá ŞÓã 'ÇáÕíÇäÉ' ÇÎÊíÇÑ äæÚ ÇáÎÏãÉ æÍÌÒ ãæÚÏ ãäÇÓÈ." },
    new { Id = 28, question = "åá ÊæÌÏ ÎÕæãÇÊ Úáì ÎÏãÇÊ ÛÓíá ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ ÊÇÈÚ ÇáÚÑæÖ ãä ÎáÇá ÇáÕİÍÉ ÇáÑÆíÓíÉ Ãæ ÇáÅÔÚÇÑÇÊ." },
    new { Id = 29, question = "åá ÎÏãÉ ÇáæäÔ ãÊÇÍÉ İí ÌãíÚ ÇáãäÇØŞ¿", Response = "äÚã¡ äÍä äÛØí ãÚÙã ÇáãäÇØŞ æäÚãá Úáì ÇáÊæÓÚ ÈÔßá ãÓÊãÑ." },
    new { Id = 30, question = "åá ÊæÌÏ æÙÇÆİ ãÊÇÍÉ áÓÇÆŞí ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ íãßäß ÇáÊŞÏíã Úáì æÙíİÉ ãä ÎáÇá ÕİÍÉ 'ÇáæÙÇÆİ' æÊÓÌíá ÈíÇäÇÊß." },
    // question 1
    new { Id = 31, question = "ÅÒÇí ÃÈíÚ ÚÑÈíÊí Úáì ÇáãäÕÉ¿", Response = "Şã ÈÅäÔÇÁ ÍÓÇÈ Úáì ÇáãäÕÉ¡ Ëã ÇäÊŞá Åáì ŞÓã 'ÈíÚ ÓíÇÑÉ'¡ æÇãáÃ ÇáÈíÇäÇÊ ÇáãØáæÈÉ æÇÑİÚ ÕæÑ ÇáÓíÇÑÉ." },
    new { Id = 32, question = "How can I sell my car on the platform?", Response = "Create an account on the platform, go to the 'Sell Car' section, fill in the required details and upload the car images." },
    new { Id = 33, question = "ßíİ íãßääí ÈíÚ ÓíÇÑÊí Úáì ÇáãäÕÉ¿", Response = "Şã ÈÅäÔÇÁ ÍÓÇÈ Úáì ÇáãäÕÉ¡ Ëã ÇäÊŞá Åáì ŞÓã 'ÈíÚ ÓíÇÑÉ'¡ æÇãáÃ ÇáÈíÇäÇÊ ÇáãØáæÈÉ æÇÑİÚ ÕæÑ ÇáÓíÇÑÉ." },
    // question 2
    new { Id = 34, question = "åá íÌÈ İÍÕ ÇáÓíÇÑÉ ŞÈá ÈíÚåÇ¿", Response = "ÇáİÍÕ áíÓ ÅáÒÇãíÇğ¡ æáßäå íÒíÏ ãä ãÕÏÇŞíÉ ÇáÅÚáÇä æíÓÇÚÏ İí ÈíÚ ÇáÓíÇÑÉ ÈÔßá ÃÓÑÚ." },
    new { Id = 35, question = "Do I need to inspect the car before selling?", Response = "Inspection is not mandatory, but it increases credibility and helps sell the car faster." },
    new { Id = 36, question = "åá íÌÈ İÍÕ ÇáÓíÇÑÉ ŞÈá ÈíÚåÇ¿", Response = "ÇáİÍÕ áíÓ ÅáÒÇãíÇğ¡ æáßäå íÒíÏ ãä ãÕÏÇŞíÉ ÇáÅÚáÇä æíÓÇÚÏ İí ÈíÚ ÇáÓíÇÑÉ ÈÔßá ÃÓÑÚ." },
    // question 3
    new { Id = 37, question = "åá ÊæÌÏ ÚãæáÉ Úáì ÚãáíÉ ÇáÈíÚ¿", Response = "äÚã¡ ÇáãäÕÉ ÊÍÕá Úáì ÚãæáÉ ÈÓíØÉ ÈÚÏ ÅÊãÇã ÚãáíÉ ÇáÈíÚ ÈäÌÇÍ." },
    new { Id = 38, question = "Is there a commission on the sale?", Response = "Yes, the platform takes a small commission after the sale is completed successfully." },
    new { Id = 39, question = "åá ÊæÌÏ ÚãæáÉ Úáì ÚãáíÉ ÇáÈíÚ¿", Response = "äÚã¡ ÇáãäÕÉ ÊÍÕá Úáì ÚãæáÉ ÈÓíØÉ ÈÚÏ ÅÊãÇã ÚãáíÉ ÇáÈíÚ ÈäÌÇÍ." },
    // question 4
    new { Id = 40, question = "ßíİ íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ¿", Response = "ÇäÊŞá Åáì ŞÓã 'ÊÃÌíÑ ÇáÓíÇÑÇÊ'¡ æÇÎÊÑ ÇáÓíÇÑÉ æÇáÊÇÑíÎ¡ Ëã ÇÖÛØ Úáì ÒÑ ÇáÍÌÒ." },
    new { Id = 41, question = "How can I rent a car?", Response = "Go to the 'Car Rental' section, choose the car and date, then click the book button." },
    new { Id = 42, question = "ßíİ íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ¿", Response = "ÇäÊŞá Åáì ŞÓã 'ÊÃÌíÑ ÇáÓíÇÑÇÊ'¡ æÇÎÊÑ ÇáÓíÇÑÉ æÇáÊÇÑíÎ¡ Ëã ÇÖÛØ Úáì ÒÑ ÇáÍÌÒ." },
    // question 5
    new { Id = 43, question = "åá íÔãá ÊÃÌíÑ ÇáÓíÇÑÇÊ ÇáÊÃãíä¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ÇáãÄÌÑÉ ÊÔãá ÊÃãíäÇğ ÔÇãáÇğ ØæÇá ãÏÉ ÇáÅíÌÇÑ." },
    new { Id = 44, question = "Does car rental include insurance?", Response = "Yes, all rental cars come with full insurance during the rental period." },
    new { Id = 45, question = "åá íÔãá ÊÃÌíÑ ÇáÓíÇÑÇÊ ÇáÊÃãíä¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ÇáãÄÌÑÉ ÊÔãá ÊÃãíäÇğ ÔÇãáÇğ ØæÇá ãÏÉ ÇáÅíÌÇÑ." },
    // question 6
    new { Id = 46, question = "åá íãßääí ÅÚÇÏÉ ÇáÓíÇÑÉ ŞÈá ÇáãæÚÏ ÇáãÍÏÏ¿", Response = "äÚã¡ æáßä ŞÏ íÊã ÎÕã ÑÓæã ÍÓÈ ÓíÇÓÉ ÇáÅáÛÇÁ ÇáÎÇÕÉ ÈÇáÓíÇÑÉ." },
    new { Id = 47, question = "Can I return the car before the scheduled time?", Response = "Yes, but there may be a cancellation fee depending on the car's policy." },
    new { Id = 48, question = "åá íãßääí ÅÚÇÏÉ ÇáÓíÇÑÉ ŞÈá ÇáãæÚÏ ÇáãÍÏÏ¿", Response = "äÚã¡ æáßä ŞÏ íÊã ÎÕã ÑÓæã ÍÓÈ ÓíÇÓÉ ÇáÅáÛÇÁ ÇáÎÇÕÉ ÈÇáÓíÇÑÉ." },
    // question 7
    new { Id = 49, question = "åá íãßääí ØáÈ ÎÏãÉ ÕíÇäÉ ááÓíÇÑÉ¿", Response = "äÚã¡ íãßäß ãä ÎáÇá ŞÓã 'ÇáÕíÇäÉ' ÇÎÊíÇÑ äæÚ ÇáÎÏãÉ æÍÌÒ ãæÚÏ ãäÇÓÈ." },
    new { Id = 50, question = "Can I request car maintenance?", Response = "Yes, you can select the service type and book an appointment through the 'Maintenance' section." },
    new { Id = 51, question = "åá íãßääí ØáÈ ÎÏãÉ ÕíÇäÉ ááÓíÇÑÉ¿", Response = "äÚã¡ íãßäß ãä ÎáÇá ŞÓã 'ÇáÕíÇäÉ' ÇÎÊíÇÑ äæÚ ÇáÎÏãÉ æÍÌÒ ãæÚÏ ãäÇÓÈ." },
    // question 8
    new { Id = 52, question = "åá ÊæÌÏ ÎÕæãÇÊ Úáì ÎÏãÇÊ ÛÓíá ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ ÊÇÈÚ ÇáÚÑæÖ ãä ÎáÇá ÇáÕİÍÉ ÇáÑÆíÓíÉ Ãæ ÇáÅÔÚÇÑÇÊ." },
    new { Id = 53, question = "Are there discounts on car wash services?", Response = "Yes, keep an eye on offers through the homepage or notifications." },
    new { Id = 54, question = "åá ÊæÌÏ ÎÕæãÇÊ Úáì ÎÏãÇÊ ÛÓíá ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ ÊÇÈÚ ÇáÚÑæÖ ãä ÎáÇá ÇáÕİÍÉ ÇáÑÆíÓíÉ Ãæ ÇáÅÔÚÇÑÇÊ." },
    // question 9
    new { Id = 55, question = "åá ÎÏãÉ ÇáæäÔ ãÊÇÍÉ İí ÌãíÚ ÇáãäÇØŞ¿", Response = "äÚã¡ äÍä äÛØí ãÚÙã ÇáãäÇØŞ æäÚãá Úáì ÇáÊæÓÚ ÈÔßá ãÓÊãÑ." },
    new { Id = 56, question = "Is the towing service available in all areas?", Response = "Yes, we cover most regions and are continuously expanding." },
    new { Id = 57, question = "åá ÎÏãÉ ÇáæäÔ ãÊÇÍÉ İí ÌãíÚ ÇáãäÇØŞ¿", Response = "äÚã¡ äÍä äÛØí ãÚÙã ÇáãäÇØŞ æäÚãá Úáì ÇáÊæÓÚ ÈÔßá ãÓÊãÑ." },
    // question 10
    new { Id = 58, question = "åá ÊæÌÏ æÙÇÆİ ãÊÇÍÉ áÓÇÆŞí ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ íãßäß ÇáÊŞÏíã Úáì æÙíİÉ ãä ÎáÇá ÕİÍÉ 'ÇáæÙÇÆİ' æÊÓÌíá ÈíÇäÇÊß." },
    new { Id = 59, question = "Are there driver job openings?", Response = "Yes, you can apply for a driver position through the 'Jobs' page and submit your details." },
    new { Id = 60, question = "åá ÊæÌÏ æÙÇÆİ ãÊÇÍÉ áÓÇÆŞí ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ íãßäß ÇáÊŞÏíã Úáì æÙíİÉ ãä ÎáÇá ÕİÍÉ 'ÇáæÙÇÆİ' æÊÓÌíá ÈíÇäÇÊß." },
    // question 11
    new { Id = 61, question = "åá íãßääí ÊÚÏíá ÕæÑ ÇáÓíÇÑÉ ÈÚÏ äÔÑ ÇáÅÚáÇä¿", Response = "äÚã¡ íãßäß ÊÚÏíá ÇáÕæÑ İí Ãí æŞÊ ãä ÎáÇá ÕİÍÉ ÅÏÇÑÉ ÇáÅÚáÇäÇÊ." },
    new { Id = 62, question = "Can I edit car images after posting the ad?", Response = "Yes, you can edit the images anytime from the ad management page." },
    new { Id = 63, question = "åá íãßääí ÊÚÏíá ÕæÑ ÇáÓíÇÑÉ ÈÚÏ äÔÑ ÇáÅÚáÇä¿", Response = "äÚã¡ íãßäß ÊÚÏíá ÇáÕæÑ İí Ãí æŞÊ ãä ÎáÇá ÕİÍÉ ÅÏÇÑÉ ÇáÅÚáÇäÇÊ." },
    // question 12
    new { Id = 64, question = "ãÇ åí ÔÑæØ ÊÃÌíÑ ÇáÓíÇÑÇÊ¿", Response = "íÔÊÑØ Ãä íßæä ÚãÑß İæŞ 21 ÓäÉ æÃä Êßæä áÏíß ÑÎÕÉ ŞíÇÏÉ ÓÇÑíÉ." },
    new { Id = 65, question = "What are the conditions for renting a car?", Response = "You must be over 21 years old and have a valid driving license." },
    new { Id = 66, question = "ãÇ åí ÔÑæØ ÊÃÌíÑ ÇáÓíÇÑÇÊ¿", Response = "íÔÊÑØ Ãä íßæä ÚãÑß İæŞ 21 ÓäÉ æÃä Êßæä áÏíß ÑÎÕÉ ŞíÇÏÉ ÓÇÑíÉ." },
    // question 13
    new { Id = 67, question = "åá ÊÊæİÑ ÓíÇÑÇÊ ÃæÊæãÇÊíßíÉ ááÊÃÌíÑ¿", Response = "äÚã¡ ÊÊæİÑ áÏíäÇ ÓíÇÑÇÊ ÃæÊæãÇÊíßíÉ ááÅíÌÇÑ." },
    new { Id = 68, question = "Are automatic cars available for rental?", Response = "Yes, we have automatic cars available for rent." },
    new { Id = 69, question = "åá ÊÊæİÑ ÓíÇÑÇÊ ÃæÊæãÇÊíßíÉ ááÊÃÌíÑ¿", Response = "äÚã¡ ÊÊæİÑ áÏíäÇ ÓíÇÑÇÊ ÃæÊæãÇÊíßíÉ ááÅíÌÇÑ." },
    // question 14
    new { Id = 70, question = "ãÇĞÇ ÃİÚá ÅĞÇ ÊÚØáÊ ÇáÓíÇÑÉ ÃËäÇÁ İÊÑÉ ÇáÅíÌÇÑ¿", Response = "İí ÍÇá ÍÏæË Ãí ÚØá¡ íÑÌì ÇáÇÊÕÇá ÈÎÏãÉ ÇáÚãáÇÁ ááÊæÌíå æÇáÅÕáÇÍ." },
    new { Id = 71, question = "What should I do if the car breaks down during rental?", Response = "In case of breakdown, please contact customer service for guidance and repair." },
    new { Id = 72, question = "ãÇĞÇ ÃİÚá ÅĞÇ ÊÚØáÊ ÇáÓíÇÑÉ ÃËäÇÁ İÊÑÉ ÇáÅíÌÇÑ¿", Response = "İí ÍÇá ÍÏæË Ãí ÚØá¡ íÑÌì ÇáÇÊÕÇá ÈÎÏãÉ ÇáÚãáÇÁ ááÊæÌíå æÇáÅÕáÇÍ." },
    // question 15
    new { Id = 73, question = "Ãíä ÊÊã ÎÏãÇÊ ÇáÕíÇäÉ æßã ãä ÇáæŞÊ ÊÓÊÛÑŞ¿", Response = "ÎÏãÇÊ ÇáÕíÇäÉ ÊÊã İí ãÑÇßÒ ãÚÊãÏÉ æíãßäß ÊÍÏíÏ ãæÚÏ ÇáÕíÇäÉ ÚÈÑ ÇáÊØÈíŞ." },
    new { Id = 74, question = "Where do maintenance services take place and how long do they take?", Response = "Maintenance services are carried out at authorized centers, and you can schedule an appointment through the app." },
    new { Id = 75, question = "Ãíä ÊÊã ÎÏãÇÊ ÇáÕíÇäÉ æßã ãä ÇáæŞÊ ÊÓÊÛÑŞ¿", Response = "ÎÏãÇÊ ÇáÕíÇäÉ ÊÊã İí ãÑÇßÒ ãÚÊãÏÉ æíãßäß ÊÍÏíÏ ãæÚÏ ÇáÕíÇäÉ ÚÈÑ ÇáÊØÈíŞ." },
    // question 16
    new { Id = 76, question = "ßíİ íãßääí ØáÈ ÎÏãÉ ÇáÓÍÈ (ÇáæäÔ)¿", Response = "íãßäß ØáÈ ÇáÎÏãÉ ãä ÎáÇá ÇáÊØÈíŞ İí ŞÓã 'ÇáæäÔ'." },
    new { Id = 77, question = "How can I request the towing service?", Response = "You can request the towing service through the app in the 'Towing' section." },
    new { Id = 78, question = "ßíİ íãßääí ØáÈ ÎÏãÉ ÇáÓÍÈ (ÇáæäÔ)¿", Response = "íãßäß ØáÈ ÇáÎÏãÉ ãä ÎáÇá ÇáÊØÈíŞ İí ŞÓã 'ÇáæäÔ'." },
    // question 17
    new { Id = 79, question = "åá íãßääí ÍÌÒ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ ãä ÎáÇá ÇáÊØÈíŞ¿", Response = "äÚã¡ íãßäß ÍÌÒ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ ÚÈÑ ÇáÊØÈíŞ İí Ãí æŞÊ." },
    new { Id = 80, question = "Can I book a car wash service through the app?", Response = "Yes, you can book the car wash service anytime through the app." },
    new { Id = 81, question = "åá íãßääí ÍÌÒ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ ãä ÎáÇá ÇáÊØÈíŞ¿", Response = "äÚã¡ íãßäß ÍÌÒ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ ÚÈÑ ÇáÊØÈíŞ İí Ãí æŞÊ." },
    // question 18
    new { Id = 82, question = "åá ÊÊæİÑ ŞØÚ ÛíÇÑ ÃÕáíÉ¿", Response = "äÚã¡ äŞÏã ŞØÚ ÛíÇÑ ÃÕáíÉ áÌãíÚ ÃäæÇÚ ÇáÓíÇÑÇÊ." },
    new { Id = 83, question = "Are original spare parts available?", Response = "Yes, we provide original spare parts for all types of cars." },
    new { Id = 84, question = "åá ÊÊæİÑ ŞØÚ ÛíÇÑ ÃÕáíÉ¿", Response = "äÚã¡ äŞÏã ŞØÚ ÛíÇÑ ÃÕáíÉ áÌãíÚ ÃäæÇÚ ÇáÓíÇÑÇÊ." },
    // question 19
    new { Id = 85, question = "åá íæÌÏ ŞÓã ÎÇÕ ÈİÚÇáíÇÊ ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ íæÌÏ ŞÓã ÎÇÕ ÈİÚÇáíÇÊ ÇáÓíÇÑÇÊ íãßä ãä ÎáÇáå ÇáÇØáÇÚ Úáì ÇáİÚÇáíÇÊ ÇáŞÇÏãÉ." },
    new { Id = 86, question = "Is there a section for car events?", Response = "Yes, there is a dedicated section for car events where you can check upcoming events." },
    new { Id = 87, question = "åá íæÌÏ ŞÓã ÎÇÕ ÈİÚÇáíÇÊ ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ íæÌÏ ŞÓã ÎÇÕ ÈİÚÇáíÇÊ ÇáÓíÇÑÇÊ íãßä ãä ÎáÇáå ÇáÇØáÇÚ Úáì ÇáİÚÇáíÇÊ ÇáŞÇÏãÉ." },
    // question 20
    new { Id = 88, question = "åá íãßääí ÇáÊŞÏíã Úáì æÙíİÉ Ïæä ÎÈÑÉ ÓÇÈŞÉ¿", Response = "äÚã¡ íãßäß ÇáÊŞÏíã Úáì æÙÇÆİ ãÈÊÏÆÉ¡ æäÍä äæİÑ ÊÏÑíÈÇğ ÔÇãáÇğ." },
    new { Id = 89, question = "Can I apply for a job without prior experience?", Response = "Yes, you can apply for entry-level jobs, and we provide comprehensive training." },
    new { Id = 90, question = "åá íãßääí ÇáÊŞÏíã Úáì æÙíİÉ Ïæä ÎÈÑÉ ÓÇÈŞÉ¿", Response = "äÚã¡ íãßäß ÇáÊŞÏíã Úáì æÙÇÆİ ãÈÊÏÆÉ¡ æäÍä äæİÑ ÊÏÑíÈÇğ ÔÇãáÇğ." },
    // question 21
    new { Id = 91, question = "ÅÒÇí ÃÊÚÇãá ãÚ ãÔßáÉ İí ÇáÓíÇÑÉ ÃËäÇÁ ÇáŞíÇÏÉ¿", Response = "áæ æÇÌåÊ Ãí ãÔßáÉ ÃËäÇÁ ÇáŞíÇÏÉ¡ ÍÇæá ÊæŞİ İí ãßÇä Âãä æÇÊÕá ÈÃŞÑÈ ãÑßÒ ÕíÇäÉ Ãæ ÎÏãÉ ØæÇÑÆ." },
    new { Id = 92, question = "What should I do if I face a problem with my car while driving?", Response = "If you encounter any issue while driving, try to stop in a safe place and contact the nearest service center or emergency service." },
    new { Id = 93, question = "ßíİ ÃÊÚÇãá ãÚ ãÔßáÉ İí ÇáÓíÇÑÉ ÃËäÇÁ ÇáŞíÇÏÉ¿", Response = "áæ æÇÌåÊ Ãí ãÔßáÉ ÃËäÇÁ ÇáŞíÇÏÉ¡ ÍÇæá ÊæŞİ İí ãßÇä Âãä æÇÊÕá ÈÃŞÑÈ ãÑßÒ ÕíÇäÉ Ãæ ÎÏãÉ ØæÇÑÆ." },
    // question 22
    new { Id = 94, question = "åá íãßääí ÇÓÊÑÌÇÚ ÇáÓíÇÑÉ ŞÈá ãæÚÏ ÇáÅÑÌÇÚ¿", Response = "äÚã¡ áßä ŞÏ íÊã İÑÖ ÑÓæã ÅÖÇİíÉ ÍÓÈ ÓíÇÓÉ ÇáÅÑÌÇÚ ÇáÎÇÕÉ Èßá ÓíÇÑÉ." },
    new { Id = 95, question = "Can I return the car before the return date?", Response = "Yes, but extra charges may apply based on the return policy for each car." },
    new { Id = 96, question = "åá íãßääí ÇÓÊÑÌÇÚ ÇáÓíÇÑÉ ŞÈá ãæÚÏ ÇáÅÑÌÇÚ¿", Response = "äÚã¡ áßä ŞÏ íÊã İÑÖ ÑÓæã ÅÖÇİíÉ ÍÓÈ ÓíÇÓÉ ÇáÅÑÌÇÚ ÇáÎÇÕÉ Èßá ÓíÇÑÉ." },
    // question 23
    new { Id = 97, question = "åá íãßääí ÊÃÌíÑ ÓíÇÑÉ áİÊÑÉ ŞÕíÑÉ¿", Response = "äÚã¡ äÍä äŞÏã ÎíÇÑÇÊ ÊÃÌíÑ ŞÕíÑÉ ÇáãÏÉ ÊÈÏÃ ãä íæã æÇÍÏ." },
    new { Id = 98, question = "Can I rent a car for a short period?", Response = "Yes, we offer short-term rental options starting from one day." },
    new { Id = 99, question = "åá íãßääí ÊÃÌíÑ ÓíÇÑÉ áİÊÑÉ ŞÕíÑÉ¿", Response = "äÚã¡ äÍä äŞÏã ÎíÇÑÇÊ ÊÃÌíÑ ŞÕíÑÉ ÇáãÏÉ ÊÈÏÃ ãä íæã æÇÍÏ." },
    // question 24
    new { Id = 100, question = "åá íãßääí ÊÚÏíá ÈíÇäÇÊ ÇáÅÚáÇä ÈÚÏ äÔÑå¿", Response = "äÚã¡ íãßäß ÊÚÏíá ÈíÇäÇÊ ÅÚáÇä ÇáÓíÇÑÉ ÈÚÏ äÔÑå ÚÈÑ ÍÓÇÈß Úáì ÇáãäÕÉ." },
    new { Id = 101, question = "Can I edit my ad details after posting?", Response = "Yes, you can edit the car ad details after posting through your account on the platform." },
    new { Id = 102, question = "åá íãßääí ÊÚÏíá ÈíÇäÇÊ ÇáÅÚáÇä ÈÚÏ äÔÑå¿", Response = "äÚã¡ íãßäß ÊÚÏíá ÈíÇäÇÊ ÅÚáÇä ÇáÓíÇÑÉ ÈÚÏ äÔÑå ÚÈÑ ÍÓÇÈß Úáì ÇáãäÕÉ." },
    // question 25
    new { Id = 103, question = "åá íæÌÏ ÏÚã İäí 24 ÓÇÚÉ¿", Response = "äÚã¡ äÍä äŞÏã ÏÚãğÇ İäíğÇ Úáì ãÏÇÑ ÇáÓÇÚÉ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáãæŞÚ ÇáÅáßÊÑæäí." },
    new { Id = 104, question = "Is there 24/7 technical support?", Response = "Yes, we offer 24/7 technical support through the app or website." },
    new { Id = 105, question = "åá íæÌÏ ÏÚã İäí 24 ÓÇÚÉ¿", Response = "äÚã¡ äÍä äŞÏã ÏÚãğÇ İäíğÇ Úáì ãÏÇÑ ÇáÓÇÚÉ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáãæŞÚ ÇáÅáßÊÑæäí." },
    // question 26
    new { Id = 106, question = "åá ÊæİÑ ÇáãäÕÉ ÎÏãÇÊ äŞá ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ äÍä äŞÏã ÎÏãÉ äŞá ÇáÓíÇÑÇÊ ãä æÅáì ÇáãæÇŞÚ ÇáãÎÊáİÉ ãä ÎáÇá ÎÏãÉ ÇáæäÔ." },
    new { Id = 107, question = "Does the platform provide car transport services?", Response = "Yes, we offer car transport services to and from different locations through our towing service." },
    new { Id = 108, question = "åá ÊæİÑ ÇáãäÕÉ ÎÏãÇÊ äŞá ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ äÍä äŞÏã ÎÏãÉ äŞá ÇáÓíÇÑÇÊ ãä æÅáì ÇáãæÇŞÚ ÇáãÎÊáİÉ ãä ÎáÇá ÎÏãÉ ÇáæäÔ." },
    // question 27
    new { Id = 109, question = "ßíİ íãßääí ÇáÏİÚ ãŞÇÈá ÇáÎÏãÇÊ¿", Response = "íãßäß ÇáÏİÚ ÈÇÓÊÎÏÇã ÇáÈØÇŞÉ ÇáÇÆÊãÇäíÉ Ãæ ãä ÎáÇá ÎíÇÑÇÊ ÇáÏİÚ ÇáÅáßÊÑæäí ÇáÃÎÑì ÇáãÊÇÍÉ İí ÇáÊØÈíŞ." },
    new { Id = 110, question = "How can I pay for the services?", Response = "You can pay using a credit card or through other available electronic payment options in the app." },
    new { Id = 111, question = "ßíİ íãßääí ÇáÏİÚ ãŞÇÈá ÇáÎÏãÇÊ¿", Response = "íãßäß ÇáÏİÚ ÈÇÓÊÎÏÇã ÇáÈØÇŞÉ ÇáÇÆÊãÇäíÉ Ãæ ãä ÎáÇá ÎíÇÑÇÊ ÇáÏİÚ ÇáÅáßÊÑæäí ÇáÃÎÑì ÇáãÊÇÍÉ İí ÇáÊØÈíŞ." },
    // question 28
    new { Id = 112, question = "åá íãßääí ÅÖÇİÉ ÃßËÑ ãä ÓíÇÑÉ ááÅíÌÇÑ¿", Response = "äÚã¡ íãßäß ÅÖÇİÉ ÃßËÑ ãä ÓíÇÑÉ ááÅíÌÇÑ ãä ÎáÇá ÍÓÇÈß Úáì ÇáãäÕÉ." },
    new { Id = 113, question = "Can I add more than one car for rent?", Response = "Yes, you can add more than one car for rent through your account on the platform." },
    new { Id = 114, question = "åá íãßääí ÅÖÇİÉ ÃßËÑ ãä ÓíÇÑÉ ááÅíÌÇÑ¿", Response = "äÚã¡ íãßäß ÅÖÇİÉ ÃßËÑ ãä ÓíÇÑÉ ááÅíÌÇÑ ãä ÎáÇá ÍÓÇÈß Úáì ÇáãäÕÉ." },
    // question 29
    new { Id = 115, question = "åá ÊæÌÏ ÑÓæã ÅÖÇİíÉ Úáì ÎÏãÇÊ ÛÓíá ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ ŞÏ Êßæä åäÇß ÑÓæã ÅÖÇİíÉ ÍÓÈ äæÚ ÇáÎÏãÉ Ãæ ÇáÚÑÖ ÇáãŞÏã." },
    new { Id = 116, question = "Are there extra charges for car wash services?", Response = "Yes, there may be additional charges depending on the type of service or the offered promotion." },
    new { Id = 117, question = "åá ÊæÌÏ ÑÓæã ÅÖÇİíÉ Úáì ÎÏãÇÊ ÛÓíá ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ ŞÏ Êßæä åäÇß ÑÓæã ÅÖÇİíÉ ÍÓÈ äæÚ ÇáÎÏãÉ Ãæ ÇáÚÑÖ ÇáãŞÏã." },
    // question 30
    new { Id = 118, question = "åá ÊæİÑ ÇáãäÕÉ ŞØÚ ÛíÇÑ ááÓíÇÑÇÊ ÇáİÇÑåÉ¿", Response = "äÚã¡ áÏíäÇ ŞØÚ ÛíÇÑ áÌãíÚ ÃäæÇÚ ÇáÓíÇÑÇÊ ÈãÇ İí Ğáß ÇáÓíÇÑÇÊ ÇáİÇÑåÉ." },
    new { Id = 119, question = "Does the platform provide spare parts for luxury cars?", Response = "Yes, we have spare parts for all types of cars, including luxury vehicles." },
    new { Id = 120, question = "åá ÊæİÑ ÇáãäÕÉ ŞØÚ ÛíÇÑ ááÓíÇÑÇÊ ÇáİÇÑåÉ¿", Response = "äÚã¡ áÏíäÇ ŞØÚ ÛíÇÑ áÌãíÚ ÃäæÇÚ ÇáÓíÇÑÇÊ ÈãÇ İí Ğáß ÇáÓíÇÑÇÊ ÇáİÇÑåÉ." },
    // question 31
    new { Id = 121, question = "åá ÊæÌÏ ÈÑÇãÌ æáÇÁ áÚãáÇÁ ÇáÅíÌÇÑ¿", Response = "äÚã¡ áÏíäÇ ÈÑÇãÌ æáÇÁ ÊŞÏã ÎÕæãÇÊ æÚÑæÖ ÎÇÕÉ ááÚãáÇÁ ÇáãÊßÑÑíä." },
    new { Id = 122, question = "Are there loyalty programs for rental customers?", Response = "Yes, we have loyalty programs offering discounts and special offers for repeat customers." },
    new { Id = 123, question = "åá ÊæÌÏ ÈÑÇãÌ æáÇÁ áÚãáÇÁ ÇáÅíÌÇÑ¿", Response = "äÚã¡ áÏíäÇ ÈÑÇãÌ æáÇÁ ÊŞÏã ÎÕæãÇÊ æÚÑæÖ ÎÇÕÉ ááÚãáÇÁ ÇáãÊßÑÑíä." },
    // question 32
    new { Id = 124, question = "ßíİ íãßääí ÊŞííã ÇáÎÏãÉ¿", Response = "íãßäß ÊŞííã ÇáÎÏãÉ ÈÚÏ ßá ÚãáíÉ ãä ÎáÇá ÇáÊØÈíŞ İí ŞÓã ÇáÊŞííãÇÊ." },
    new { Id = 125, question = "How can I rate the service?", Response = "You can rate the service after every transaction through the app in the ratings section." },
    new { Id = 126, question = "ßíİ íãßääí ÊŞííã ÇáÎÏãÉ¿", Response = "íãßäß ÊŞííã ÇáÎÏãÉ ÈÚÏ ßá ÚãáíÉ ãä ÎáÇá ÇáÊØÈíŞ İí ŞÓã ÇáÊŞííãÇÊ." },
    // question 33
    new { Id = 127, question = "åá íãßääí ÅáÛÇÁ ÇáÍÌÒ ÈÚÏ ÇáÏİÚ¿", Response = "äÚã¡ íãßäß ÅáÛÇÁ ÇáÍÌÒ æáßä ÓíÊã ÎÕã ÑÓæã ÅáÛÇÁ ÈäÇÁğ Úáì ÓíÇÓÉ ÇáãäÕÉ." },
    new { Id = 128, question = "Can I cancel the reservation after payment?", Response = "Yes, you can cancel the reservation, but cancellation fees may apply based on the platform's policy." },
    new { Id = 129, question = "åá íãßääí ÅáÛÇÁ ÇáÍÌÒ ÈÚÏ ÇáÏİÚ¿", Response = "äÚã¡ íãßäß ÅáÛÇÁ ÇáÍÌÒ æáßä ÓíÊã ÎÕã ÑÓæã ÅáÛÇÁ ÈäÇÁğ Úáì ÓíÇÓÉ ÇáãäÕÉ." },
    // question 34
    new { Id = 130, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ ááÇÓÊÎÏÇã Çáíæãí¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÓíÇÑÇÊ ááÇÓÊÎÏÇã Çáíæãí ÍÓÈ ÊæİÑåÇ." },
    new { Id = 131, question = "Can I rent a car for daily use?", Response = "Yes, you can rent cars for daily use based on availability." },
    new { Id = 132, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ ááÇÓÊÎÏÇã Çáíæãí¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÓíÇÑÇÊ ááÇÓÊÎÏÇã Çáíæãí ÍÓÈ ÊæİÑåÇ." },
    // question 35
    new { Id = 133, question = "åá ÃÍÊÇÌ Åáì ÑÎÕÉ ŞíÇÏÉ ÏæáíÉ ááÅíÌÇÑ¿", Response = "áÇ¡ íßİí Ãä Êßæä áÏíß ÑÎÕÉ ŞíÇÏÉ ÓÇÑíÉ ÇáãİÚæá ãä ÈáÏß." },
    new { Id = 134, question = "Do I need an international driving license to rent a car?", Response = "No, a valid driving license from your country is sufficient." },
    new { Id = 135, question = "åá ÃÍÊÇÌ Åáì ÑÎÕÉ ŞíÇÏÉ ÏæáíÉ ááÅíÌÇÑ¿", Response = "áÇ¡ íßİí Ãä Êßæä áÏíß ÑÎÕÉ ŞíÇÏÉ ÓÇÑíÉ ÇáãİÚæá ãä ÈáÏß." },
    // question 36
    new { Id = 136, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ ÈãŞÚÏ Øİá¿", Response = "äÚã¡ ÊÊæİÑ áÏíäÇ ÓíÇÑÇÊ ãÌåÒÉ ÈãŞÇÚÏ ááÃØİÇá ÚäÏ ÇáØáÈ." },
    new { Id = 137, question = "Can I rent a car with a child seat?", Response = "Yes, we offer cars equipped with child seats upon request." },
    new { Id = 138, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ ÈãŞÚÏ Øİá¿", Response = "äÚã¡ ÊÊæİÑ áÏíäÇ ÓíÇÑÇÊ ãÌåÒÉ ÈãŞÇÚÏ ááÃØİÇá ÚäÏ ÇáØáÈ." },
    // question 37
    new { Id = 139, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ ÑíÇÖíÉ¿", Response = "äÚã¡ áÏíäÇ ÓíÇÑÇÊ ÑíÇÖíÉ ááÇíÌÇÑ ÍÓÈ ÊæİÑåÇ." },
    new { Id = 140, question = "Can I rent a sports car?", Response = "Yes, we have sports cars available for rent based on availability." },
    new { Id = 141, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ ÑíÇÖíÉ¿", Response = "äÚã¡ áÏíäÇ ÓíÇÑÇÊ ÑíÇÖíÉ ááÇíÌÇÑ ÍÓÈ ÊæİÑåÇ." },
    // question 38
    new { Id = 142, question = "ßíİ íãßääí ÅáÛÇÁ ÍÓÇÈí¿", Response = "íãßäß ÅáÛÇÁ ÍÓÇÈß ãä ÎáÇá ÇáÅÚÏÇÏÇÊ İí ÇáÊØÈíŞ¡ æÓæİ äÓÇÚÏß İí ÅÊãÇã ÇáÚãáíÉ." },
    new { Id = 143, question = "How can I delete my account?", Response = "You can delete your account through the settings in the app, and we will assist you in the process." },
    new { Id = 144, question = "ßíİ íãßääí ÅáÛÇÁ ÍÓÇÈí¿", Response = "íãßäß ÅáÛÇÁ ÍÓÇÈß ãä ÎáÇá ÇáÅÚÏÇÏÇÊ İí ÇáÊØÈíŞ¡ æÓæİ äÓÇÚÏß İí ÅÊãÇã ÇáÚãáíÉ." },
    // question 39
    new { Id = 145, question = "åá ÊŞÏãæä ÎÏãÉ ÊæÕíá ááÓíÇÑÇÊ¿", Response = "äÚã¡ äÍä äæİÑ ÎÏãÉ ÊæÕíá ÇáÓíÇÑÇÊ Åáì ÇáãæŞÚ ÇáĞí ÊÎÊÇÑå." },
    new { Id = 146, question = "Do you offer car delivery services?", Response = "Yes, we provide car delivery services to your chosen location." },
    new { Id = 147, question = "åá ÊŞÏãæä ÎÏãÉ ÊæÕíá ááÓíÇÑÇÊ¿", Response = "äÚã¡ äÍä äæİÑ ÎÏãÉ ÊæÕíá ÇáÓíÇÑÇÊ Åáì ÇáãæŞÚ ÇáĞí ÊÎÊÇÑå." },
    // question 40
    new { Id = 148, question = "åá íãßääí ÇÓÊÆÌÇÑ ÇáÓíÇÑÉ áİÊÑÉ ØæíáÉ¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÇáÓíÇÑÉ áİÊÑÉ ØæíáÉ¡ æíãßäß ÇáÊİÇæÖ Úáì ÇáÓÚÑ." },
    new { Id = 149, question = "Can I rent the car for a long period?", Response = "Yes, you can rent the car for a long period, and you can negotiate the price." },
    new { Id = 150, question = "åá íãßääí ÇÓÊÆÌÇÑ ÇáÓíÇÑÉ áİÊÑÉ ØæíáÉ¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÇáÓíÇÑÉ áİÊÑÉ ØæíáÉ¡ æíãßäß ÇáÊİÇæÖ Úáì ÇáÓÚÑ." },
    // question 41
    new { Id = 151, question = "åá íãßääí ÇáÏİÚ äŞÏğÇ¿", Response = "äÚã¡ íãßäß ÇáÏİÚ äŞÏğÇ ÚäÏ ÇÓÊáÇã ÇáÓíÇÑÉ Ãæ ÇáÎÏãÉ." },
    new { Id = 152, question = "Can I pay in cash?", Response = "Yes, you can pay in cash when receiving the car or service." },
    new { Id = 153, question = "åá íãßääí ÇáÏİÚ äŞÏğÇ¿", Response = "äÚã¡ íãßäß ÇáÏİÚ äŞÏğÇ ÚäÏ ÇÓÊáÇã ÇáÓíÇÑÉ Ãæ ÇáÎÏãÉ." },
    // question 42
    new { Id = 154, question = "ßíİ íãßääí ãÊÇÈÚÉ ÍÇáÉ ÇáÓíÇÑÉ ÇáÊí ŞãÊ ÈÍÌÒåÇ¿", Response = "íãßäß ãÊÇÈÚÉ ÍÇáÉ ÇáÓíÇÑÉ ãä ÎáÇá ÇáÊØÈíŞ¡ ÍíË ÓÊÊãßä ãä ãÚÑİÉ ãæÚÏ æÕæáåÇ Ãæ Ãí ÊÍÏíËÇÊ ÃÎÑì." },
    new { Id = 155, question = "How can I track the status of my booked car?", Response = "You can track the status of your car through the app, where you can check its arrival time and any updates." },
    new { Id = 156, question = "ßíİ íãßääí ãÊÇÈÚÉ ÍÇáÉ ÇáÓíÇÑÉ ÇáÊí ŞãÊ ÈÍÌÒåÇ¿", Response = "íãßäß ãÊÇÈÚÉ ÍÇáÉ ÇáÓíÇÑÉ ãä ÎáÇá ÇáÊØÈíŞ¡ ÍíË ÓÊÊãßä ãä ãÚÑİÉ ãæÚÏ æÕæáåÇ Ãæ Ãí ÊÍÏíËÇÊ ÃÎÑì." },
    // question 43
    new { Id = 157, question = "åá íãßääí ÇÓÊÈÏÇá ÇáÓíÇÑÉ ÎáÇá İÊÑÉ ÇáÅíÌÇÑ¿", Response = "äÚã¡ íãßäß ÇÓÊÈÏÇá ÇáÓíÇÑÉ ÎáÇá İÊÑÉ ÇáÅíÌÇÑ æáßä ÈäÇÁğ Úáì ÊæÇİÑ ÇáÓíÇÑÇÊ æÇáÔÑæØ ÇáÎÇÕÉ." },
    new { Id = 158, question = "Can I exchange the car during the rental period?", Response = "Yes, you can exchange the car during the rental period, subject to availability and the terms and conditions." },
    new { Id = 159, question = "åá íãßääí ÇÓÊÈÏÇá ÇáÓíÇÑÉ ÎáÇá İÊÑÉ ÇáÅíÌÇÑ¿", Response = "äÚã¡ íãßäß ÇÓÊÈÏÇá ÇáÓíÇÑÉ ÎáÇá İÊÑÉ ÇáÅíÌÇÑ æáßä ÈäÇÁğ Úáì ÊæÇİÑ ÇáÓíÇÑÇÊ æÇáÔÑæØ ÇáÎÇÕÉ." },
    // question 44
    new { Id = 160, question = "åá ÊæÌÏ ÎÕæãÇÊ ááãÌãæÚÇÊ¿", Response = "äÚã¡ äŞÏã ÎÕæãÇÊ ÎÇÕÉ ááãÌãæÚÇÊ ÇáÊí ÊÓÊÃÌÑ ÃßËÑ ãä ÓíÇÑÉ." },
    new { Id = 161, question = "Are there discounts for groups?", Response = "Yes, we offer special discounts for groups renting more than one car." },
    new { Id = 162, question = "åá ÊæÌÏ ÎÕæãÇÊ ááãÌãæÚÇÊ¿", Response = "äÚã¡ äŞÏã ÎÕæãÇÊ ÎÇÕÉ ááãÌãæÚÇÊ ÇáÊí ÊÓÊÃÌÑ ÃßËÑ ãä ÓíÇÑÉ." },
    // question 45
    new { Id = 163, question = "åá íãßääí ÊÍÏíÏ äæÚ ÇáÓíÇÑÉ ŞÈá ÇáÍÌÒ¿", Response = "äÚã¡ íãßäß ÊÍÏíÏ äæÚ ÇáÓíÇÑÉ ÚäÏ ÇáÍÌÒ¡ áßä Ğáß íÚÊãÏ Úáì ÇáÊæÇİÑ." },
    new { Id = 164, question = "Can I select the type of car before booking?", Response = "Yes, you can choose the type of car when booking, but this depends on availability." },
    new { Id = 165, question = "åá íãßääí ÊÍÏíÏ äæÚ ÇáÓíÇÑÉ ŞÈá ÇáÍÌÒ¿", Response = "äÚã¡ íãßäß ÊÍÏíÏ äæÚ ÇáÓíÇÑÉ ÚäÏ ÇáÍÌÒ¡ áßä Ğáß íÚÊãÏ Úáì ÇáÊæÇİÑ." },
    // question 46
    new { Id = 166, question = "åá íãßääí ÅáÛÇÁ ÇáÍÌÒ İí Ãí æŞÊ¿", Response = "äÚã¡ íãßäß ÅáÛÇÁ ÇáÍÌÒ İí Ãí æŞÊ¡ æáßä ŞÏ íÊã İÑÖ ÑÓæã ÅáÛÇÁ ÍÓÈ ÓíÇÓÉ ÇáãäÕÉ." },
    new { Id = 167, question = "Can I cancel the reservation at any time?", Response = "Yes, you can cancel the reservation at any time, but cancellation fees may apply based on the platform's policy." },
    new { Id = 168, question = "åá íãßääí ÅáÛÇÁ ÇáÍÌÒ İí Ãí æŞÊ¿", Response = "äÚã¡ íãßäß ÅáÛÇÁ ÇáÍÌÒ İí Ãí æŞÊ¡ æáßä ŞÏ íÊã İÑÖ ÑÓæã ÅáÛÇÁ ÍÓÈ ÓíÇÓÉ ÇáãäÕÉ." },
    // question 47
    new { Id = 169, question = "åá íæÌÏ ÊÃãíä Úáì ÇáÓíÇÑÉ¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ÊÃÊí ãÚ ÊÃãíä ÔÇãá ááÍæÇÏË æÇáÖÑÑ." },
    new { Id = 170, question = "Is insurance provided for the car?", Response = "Yes, all cars come with comprehensive insurance for accidents and damage." },
    new { Id = 171, question = "åá íæÌÏ ÊÃãíä Úáì ÇáÓíÇÑÉ¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ÊÃÊí ãÚ ÊÃãíä ÔÇãá ááÍæÇÏË æÇáÖÑÑ." },
    // question 48
    new { Id = 172, question = "åá íãßääí ÊÚÏíá ãæÚÏ ÇáÇÓÊáÇã¿", Response = "äÚã¡ íãßäß ÊÚÏíá ãæÚÏ ÇáÇÓÊáÇã ãä ÎáÇá ÇáÊØÈíŞ ŞÈá ÇáãæÚÏ ÇáãÍÏÏ." },
    new { Id = 173, question = "Can I modify the pickup time?", Response = "Yes, you can modify the pickup time through the app before the scheduled time." },
    new { Id = 174, question = "åá íãßääí ÊÚÏíá ãæÚÏ ÇáÇÓÊáÇã¿", Response = "äÚã¡ íãßäß ÊÚÏíá ãæÚÏ ÇáÇÓÊáÇã ãä ÎáÇá ÇáÊØÈíŞ ŞÈá ÇáãæÚÏ ÇáãÍÏÏ." },
    // question 49
    new { Id = 175, question = "åá íãßääí ÇáÍÕæá Úáì ÓíÇÑÉ ãÚ ÓÇÆŞ¿", Response = "äÚã¡ íãßäß ØáÈ ÓíÇÑÉ ãÚ ÓÇÆŞ ÚÈÑ ÇáÊØÈíŞ." },
    new { Id = 176, question = "Can I get a car with a driver?", Response = "Yes, you can request a car with a driver through the app." },
    new { Id = 177, question = "åá íãßääí ÇáÍÕæá Úáì ÓíÇÑÉ ãÚ ÓÇÆŞ¿", Response = "äÚã¡ íãßäß ØáÈ ÓíÇÑÉ ãÚ ÓÇÆŞ ÚÈÑ ÇáÊØÈíŞ." },
    // question 50
    new { Id = 178, question = "åá íãßääí ÊÚÏíá ÍÌÒ ÇáÓíÇÑÉ ÈÚÏ ÊÃßíÏå¿", Response = "äÚã¡ íãßäß ÊÚÏíá ÍÌÒß æáßä íÚÊãÏ Ğáß Úáì ÓíÇÓÉ ÇáãäÕÉ." },
    new { Id = 179, question = "Can I modify my car reservation after confirmation?", Response = "Yes, you can modify your reservation, but this depends on the platform's policy." },
    new { Id = 180, question = "åá íãßääí ÊÚÏíá ÍÌÒ ÇáÓíÇÑÉ ÈÚÏ ÊÃßíÏå¿", Response = "äÚã¡ íãßäß ÊÚÏíá ÍÌÒß æáßä íÚÊãÏ Ğáß Úáì ÓíÇÓÉ ÇáãäÕÉ." },
    // question 51
    new { Id = 181, question = "åá íãßääí ÍÌÒ ÓíÇÑÉ áÚÏÉ ÃíÇã¿", Response = "äÚã¡ íãßäß ÍÌÒ ÇáÓíÇÑÉ áãÏÉ ÚÏÉ ÃíÇã æİŞğÇ áÇÍÊíÇÌÇÊß." },
    new { Id = 182, question = "Can I book a car for several days?", Response = "Yes, you can book the car for several days based on your needs." },
    new { Id = 183, question = "åá íãßääí ÍÌÒ ÓíÇÑÉ áÚÏÉ ÃíÇã¿", Response = "äÚã¡ íãßäß ÍÌÒ ÇáÓíÇÑÉ áãÏÉ ÚÏÉ ÃíÇã æİŞğÇ áÇÍÊíÇÌÇÊß." },
    // question 52
    new { Id = 184, question = "åá íæÌÏ ÖãÇä ááÓíÇÑÉ¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ÊÃÊí ãÚ ÖãÇä ÖÏ ÇáÃÚØÇá ÇáÊí ÊÍÏË ÎáÇá İÊÑÉ ÇáÅíÌÇÑ." },
    new { Id = 185, question = "Is there a warranty for the car?", Response = "Yes, all cars come with a warranty against breakdowns during the rental period." },
    new { Id = 186, question = "åá íæÌÏ ÖãÇä ááÓíÇÑÉ¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ÊÃÊí ãÚ ÖãÇä ÖÏ ÇáÃÚØÇá ÇáÊí ÊÍÏË ÎáÇá İÊÑÉ ÇáÅíÌÇÑ." },
    // question 53
    new { Id = 187, question = "ßíİ íãßääí ãÚÑİÉ ÍÇáÉ ÕíÇäÉ ÇáÓíÇÑÉ¿", Response = "íãßäß ãÚÑİÉ ÍÇáÉ ÇáÕíÇäÉ ãä ÎáÇá ÇáÊØÈíŞ Ãæ Úä ØÑíŞ ÇáÊæÇÕá ãÚ İÑíŞ ÇáÏÚã." },
    new { Id = 188, question = "How can I know the car's maintenance status?", Response = "You can know the maintenance status through the app or by contacting the support team." },
    new { Id = 189, question = "ßíİ íãßääí ãÚÑİÉ ÍÇáÉ ÕíÇäÉ ÇáÓíÇÑÉ¿", Response = "íãßäß ãÚÑİÉ ÍÇáÉ ÇáÕíÇäÉ ãä ÎáÇá ÇáÊØÈíŞ Ãæ Úä ØÑíŞ ÇáÊæÇÕá ãÚ İÑíŞ ÇáÏÚã." },
    // question 54
    new { Id = 190, question = "åá íãßääí ÍÌÒ ÓíÇÑÉ Ïæä ÏİÚ ÇáãÈáÛ ÈÇáßÇãá¿", Response = "äÚã¡ íãßäß ÏİÚ ÌÒÁ ãä ÇáãÈáÛ ÚäÏ ÇáÍÌÒ¡ Ëã ÏİÚ ÇáÈÇŞí ÚäÏ ÇÓÊáÇã ÇáÓíÇÑÉ." },
    new { Id = 191, question = "Can I book a car without paying the full amount?", Response = "Yes, you can pay a portion of the amount when booking, and the remainder when receiving the car." },
    new { Id = 192, question = "åá íãßääí ÍÌÒ ÓíÇÑÉ Ïæä ÏİÚ ÇáãÈáÛ ÈÇáßÇãá¿", Response = "äÚã¡ íãßäß ÏİÚ ÌÒÁ ãä ÇáãÈáÛ ÚäÏ ÇáÍÌÒ¡ Ëã ÏİÚ ÇáÈÇŞí ÚäÏ ÇÓÊáÇã ÇáÓíÇÑÉ." },
    // question 55
    new { Id = 193, question = "åá íãßääí ÊÛííÑ äæÚ ÇáÓíÇÑÉ ÈÚÏ ÇáÍÌÒ¿", Response = "äÚã¡ æáßä íÚÊãÏ Ğáß Úáì ÊæÇİÑ ÇáÓíÇÑÇÊ ÇáÃÎÑì. íãßäß ÇáÊæÇÕá ãÚäÇ áÊÚÏíá ÇáÍÌÒ." },
    new { Id = 194, question = "Can I change the type of car after booking?", Response = "Yes, but it depends on the availability of other cars. You can contact us to modify the booking." },
    new { Id = 195, question = "åá íãßääí ÊÛííÑ äæÚ ÇáÓíÇÑÉ ÈÚÏ ÇáÍÌÒ¿", Response = "äÚã¡ æáßä íÚÊãÏ Ğáß Úáì ÊæÇİÑ ÇáÓíÇÑÇÊ ÇáÃÎÑì. íãßäß ÇáÊæÇÕá ãÚäÇ áÊÚÏíá ÇáÍÌÒ." },
    // question 56
    new { Id = 196, question = "åá íÊã ÊæİíÑ ÎÏãÉ ÊæÕíá ááÓíÇÑÇÊ İí ÌãíÚ ÇáãÏä¿", Response = "äÚã¡ äŞÏã ÎÏãÉ ÊæÕíá ÇáÓíÇÑÇÊ İí ãÚÙã ÇáãÏä ÇáÊí äÚãá ÈåÇ." },
    new { Id = 197, question = "Is car delivery available in all cities?", Response = "Yes, we provide car delivery services in most of the cities we operate in." },
    new { Id = 198, question = "åá íÊã ÊæİíÑ ÎÏãÉ ÊæÕíá ááÓíÇÑÇÊ İí ÌãíÚ ÇáãÏä¿", Response = "äÚã¡ äŞÏã ÎÏãÉ ÊæÕíá ÇáÓíÇÑÇÊ İí ãÚÙã ÇáãÏä ÇáÊí äÚãá ÈåÇ." },
    // question 57
    new { Id = 199, question = "åá íãßääí ÊÛííÑ æŞÊ ÊÓáíã ÇáÓíÇÑÉ¿", Response = "äÚã¡ íãßäß ÊÚÏíá æŞÊ ÇáÊÓáíã ŞÈá ÇáãæÚÏ ÇáãÍÏÏ ãä ÎáÇá ÇáÊØÈíŞ." },
    new { Id = 200, question = "Can I change the car delivery time?", Response = "Yes, you can modify the delivery time before the scheduled time through the app." },
    new { Id = 201, question = "åá íãßääí ÊÛííÑ æŞÊ ÊÓáíã ÇáÓíÇÑÉ¿", Response = "äÚã¡ íãßäß ÊÚÏíá æŞÊ ÇáÊÓáíã ŞÈá ÇáãæÚÏ ÇáãÍÏÏ ãä ÎáÇá ÇáÊØÈíŞ." },
    // question 58
    new { Id = 202, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ ÈÏæä ÈØÇŞÉ ÇÆÊãÇä¿", Response = "äÚã¡ æáßä ŞÏ ÊÍÊÇÌ Åáì ÊŞÏíã ÊÃãíä äŞÏí ÈÏáÇğ ãä ÈØÇŞÉ ÇáÇÆÊãÇä." },
    new { Id = 203, question = "Can I rent a car without a credit card?", Response = "Yes, but you may need to provide a cash deposit instead of a credit card." },
    new { Id = 204, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ ÈÏæä ÈØÇŞÉ ÇÆÊãÇä¿", Response = "äÚã¡ æáßä ŞÏ ÊÍÊÇÌ Åáì ÊŞÏíã ÊÃãíä äŞÏí ÈÏáÇğ ãä ÈØÇŞÉ ÇáÇÆÊãÇä." },
    // question 59
    new { Id = 205, question = "åá ÊÊæİÑ ÓíÇÑÇÊ İÇÎÑÉ ááÅíÌÇÑ¿", Response = "äÚã¡ áÏíäÇ ãÌãæÚÉ ãä ÇáÓíÇÑÇÊ ÇáİÇÎÑÉ ÇáÊí íãßäß ÇÓÊÆÌÇÑåÇ." },
    new { Id = 206, question = "Are luxury cars available for rent?", Response = "Yes, we have a selection of luxury cars available for rent." },
    new { Id = 207, question = "åá ÊÊæİÑ ÓíÇÑÇÊ İÇÎÑÉ ááÅíÌÇÑ¿", Response = "äÚã¡ áÏíäÇ ãÌãæÚÉ ãä ÇáÓíÇÑÇÊ ÇáİÇÎÑÉ ÇáÊí íãßäß ÇÓÊÆÌÇÑåÇ." },
    // question 60
    new { Id = 208, question = "ßíİ íãßääí ØáÈ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ¿", Response = "íãßäß ØáÈ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáÊæÇÕá ãÚ İÑíŞ ÇáÏÚã." },
    new { Id = 209, question = "How can I request a car wash service?", Response = "You can request the car wash service through the app or by contacting the support team." },
    new { Id = 210, question = "ßíİ íãßääí ØáÈ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ¿", Response = "íãßäß ØáÈ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáÊæÇÕá ãÚ İÑíŞ ÇáÏÚã." },
    // question 61
    new { Id = 211, question = "åá íãßääí ØáÈ ÎÏãÇÊ ÕíÇäÉ ÃËäÇÁ İÊÑÉ ÇáÅíÌÇÑ¿", Response = "äÚã¡ íãßäß ØáÈ ÎÏãÇÊ ÕíÇäÉ ÎáÇá İÊÑÉ ÇáÅíÌÇÑ æİŞğÇ ááÔÑæØ ÇáãÊÇÍÉ." },
    new { Id = 212, question = "Can I request maintenance services during the rental period?", Response = "Yes, you can request maintenance services during the rental period according to the available terms." },
    new { Id = 213, question = "åá íãßääí ØáÈ ÎÏãÇÊ ÕíÇäÉ ÃËäÇÁ İÊÑÉ ÇáÅíÌÇÑ¿", Response = "äÚã¡ íãßäß ØáÈ ÎÏãÇÊ ÕíÇäÉ ÎáÇá İÊÑÉ ÇáÅíÌÇÑ æİŞğÇ ááÔÑæØ ÇáãÊÇÍÉ." },
    // question 62
    new { Id = 214, question = "åá íãßääí ÊÛííÑ ãßÇä ÊÓáíã ÇáÓíÇÑÉ¿", Response = "äÚã¡ íãßäß ÊÚÏíá ãßÇä ÊÓáíã ÇáÓíÇÑÉ ÅĞÇ ßÇäÊ ÇáÎÏãÉ ãÊÇÍÉ İí ÇáãæŞÚ ÇáÌÏíÏ." },
    new { Id = 215, question = "Can I change the car delivery location?", Response = "Yes, you can modify the delivery location if the service is available at the new location." },
    new { Id = 216, question = "åá íãßääí ÊÛííÑ ãßÇä ÊÓáíã ÇáÓíÇÑÉ¿", Response = "äÚã¡ íãßäß ÊÚÏíá ãßÇä ÊÓáíã ÇáÓíÇÑÉ ÅĞÇ ßÇäÊ ÇáÎÏãÉ ãÊÇÍÉ İí ÇáãæŞÚ ÇáÌÏíÏ." },
    // question 63
    new { Id = 217, question = "åá íãßääí ÍÌÒ ÓíÇÑÉ ãä ÎáÇá ÇáãæŞÚ ÇáÅáßÊÑæäí¿", Response = "äÚã¡ íãßäß ÍÌÒ ÇáÓíÇÑÉ ãä ÎáÇá ÇáãæŞÚ ÇáÅáßÊÑæäí Ãæ ÇáÊØÈíŞ." },
    new { Id = 218, question = "Can I book a car through the website?", Response = "Yes, you can book a car through the website or the app." },
    new { Id = 219, question = "åá íãßääí ÍÌÒ ÓíÇÑÉ ãä ÎáÇá ÇáãæŞÚ ÇáÅáßÊÑæäí¿", Response = "äÚã¡ íãßäß ÍÌÒ ÇáÓíÇÑÉ ãä ÎáÇá ÇáãæŞÚ ÇáÅáßÊÑæäí Ãæ ÇáÊØÈíŞ." },
    // question 64
    new { Id = 220, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ áÓİÑ Øæíá¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÇáÓíÇÑÉ áİÊÑÉ ØæíáÉ æÇáÓİÑ ÈåÇ áÃãÇßä ÈÚíÏÉ." },
    new { Id = 221, question = "Can I rent a car for a long trip?", Response = "Yes, you can rent the car for a long period and take it on long trips." },
    new { Id = 222, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ áÓİÑ Øæíá¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÇáÓíÇÑÉ áİÊÑÉ ØæíáÉ æÇáÓİÑ ÈåÇ áÃãÇßä ÈÚíÏÉ." },
    // question 65
    new { Id = 223, question = "åá ÃÓÊØíÚ ÇÓÊÆÌÇÑ ÓíÇÑÉ ÈÃŞá ãä 25 ÓäÉ¿", Response = "íÌÈ Ãä Êßæä İí Óä 25 Ãæ ÃßËÑ áÇÓÊÆÌÇÑ ÇáÓíÇÑÉ¡ ÈÇÓÊËäÇÁ ÈÚÖ ÇáÍÇáÇÊ ÇáÎÇÕÉ." },
    new { Id = 224, question = "Can I rent a car if I'm under 25?", Response = "You must be 25 or older to rent a car, except in some special cases." },
    new { Id = 225, question = "åá ÃÓÊØíÚ ÇÓÊÆÌÇÑ ÓíÇÑÉ ÈÃŞá ãä 25 ÓäÉ¿", Response = "íÌÈ Ãä Êßæä İí Óä 25 Ãæ ÃßËÑ áÇÓÊÆÌÇÑ ÇáÓíÇÑÉ¡ ÈÇÓÊËäÇÁ ÈÚÖ ÇáÍÇáÇÊ ÇáÎÇÕÉ." },
    // question 66
    new { Id = 226, question = "åá íãßääí ÅÖÇİÉ ÓÇÆŞ ÅÖÇİí¿", Response = "äÚã¡ íãßäß ÅÖÇİÉ ÓÇÆŞ ÅÖÇİí ãŞÇÈá ÑÓæã ÅÖÇİíÉ." },
    new { Id = 227, question = "Can I add an additional driver?", Response = "Yes, you can add an additional driver for an extra fee." },
    new { Id = 228, question = "åá íãßääí ÅÖÇİÉ ÓÇÆŞ ÅÖÇİí¿", Response = "äÚã¡ íãßäß ÅÖÇİÉ ÓÇÆŞ ÅÖÇİí ãŞÇÈá ÑÓæã ÅÖÇİíÉ." },
    // question 67
    new { Id = 229, question = "åá ÊŞÏãæä ÓíÇÑÇÊ ßåÑÈÇÆíÉ¿", Response = "äÚã¡ áÏíäÇ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ãÊÇÍÉ ááÅíÌÇÑ." },
    new { Id = 230, question = "Do you offer electric cars?", Response = "Yes, we have electric cars available for rent." },
    new { Id = 231, question = "åá ÊŞÏãæä ÓíÇÑÇÊ ßåÑÈÇÆíÉ¿", Response = "äÚã¡ áÏíäÇ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ãÊÇÍÉ ááÅíÌÇÑ." },
    // question 68
    new { Id = 232, question = "åá íæÌÏ ÎÏãÉ ÊÃãíä ÖÏ ÇáÍæÇÏË¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ÊÃÊí ãÚ ÊÃãíä ÖÏ ÇáÍæÇÏË." },
    new { Id = 233, question = "Is there accident insurance available?", Response = "Yes, all cars come with accident insurance." },
    new { Id = 234, question = "åá íæÌÏ ÎÏãÉ ÊÃãíä ÖÏ ÇáÍæÇÏË¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ÊÃÊí ãÚ ÊÃãíä ÖÏ ÇáÍæÇÏË." },
    // question 69
    new { Id = 235, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ ãÚ ÖãÇä¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ÊÃÊí ãÚ ÖãÇä ÖÏ ÇáÃÚØÇá." },
    new { Id = 236, question = "Can I rent a car with a warranty?", Response = "Yes, all cars come with a warranty against breakdowns." },
    new { Id = 237, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ ãÚ ÖãÇä¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ÊÃÊí ãÚ ÖãÇä ÖÏ ÇáÃÚØÇá." },
    // question 70
    new { Id = 238, question = "åá íãßääí ÍÌÒ ÓíÇÑÉ İí æŞÊ áÇÍŞ¿", Response = "äÚã¡ íãßäß ÍÌÒ ÇáÓíÇÑÉ İí æŞÊ áÇÍŞ ÍÓÈ ÇáÊæÇİÑ." },
    new { Id = 239, question = "Can I book a car at a later time?", Response = "Yes, you can book the car at a later time based on availability." },
    new { Id = 240, question = "åá íãßääí ÍÌÒ ÓíÇÑÉ İí æŞÊ áÇÍŞ¿", Response = "äÚã¡ íãßäß ÍÌÒ ÇáÓíÇÑÉ İí æŞÊ áÇÍŞ ÍÓÈ ÇáÊæÇİÑ." },
    // question 71
    new { Id = 241, question = "ßíİ íãßääí ÅÖÇİÉ ÍÌÒ ÂÎÑ¿", Response = "íãßäß ÅÖÇİÉ ÍÌÒ ÂÎÑ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáãæŞÚ ÇáÅáßÊÑæäí." },
    new { Id = 242, question = "How can I add another reservation?", Response = "You can add another reservation through the app or website." },
    new { Id = 243, question = "ßíİ íãßääí ÅÖÇİÉ ÍÌÒ ÂÎÑ¿", Response = "íãßäß ÅÖÇİÉ ÍÌÒ ÂÎÑ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáãæŞÚ ÇáÅáßÊÑæäí." },
    // question 72
    new { Id = 244, question = "åá íãßääí ÊÚÏíá ãæÇÚíÏ ÇáÍÌÒ ÈÚÏ ÇáÊÃßíÏ¿", Response = "äÚã¡ íãßäß ÊÚÏíá ãæÇÚíÏ ÇáÍÌÒ æáßä æİŞğÇ áÓíÇÓÉ ÇáãäÕÉ." },
    new { Id = 245, question = "Can I modify my reservation dates after confirmation?", Response = "Yes, you can modify the reservation dates, but according to the platform's policy." },
    new { Id = 246, question = "åá íãßääí ÊÚÏíá ãæÇÚíÏ ÇáÍÌÒ ÈÚÏ ÇáÊÃßíÏ¿", Response = "äÚã¡ íãßäß ÊÚÏíá ãæÇÚíÏ ÇáÍÌÒ æáßä æİŞğÇ áÓíÇÓÉ ÇáãäÕÉ." },
    // question 73
    new { Id = 247, question = "åá ÊæİÑæä ÎÏãÉ ÊÃÌíÑ ÓíÇÑÇÊ ÇáäŞá¿", Response = "äÚã¡ äæİÑ ÎÏãÉ ÊÃÌíÑ ÓíÇÑÇÊ ÇáäŞá ÇáßÈíÑÉ æÇáÕÛíÑÉ." },
    new { Id = 248, question = "Do you offer rental services for transport vehicles?", Response = "Yes, we offer rental services for both large and small transport vehicles." },
    new { Id = 249, question = "åá ÊæİÑæä ÎÏãÉ ÊÃÌíÑ ÓíÇÑÇÊ ÇáäŞá¿", Response = "äÚã¡ äæİÑ ÎÏãÉ ÊÃÌíÑ ÓíÇÑÇÊ ÇáäŞá ÇáßÈíÑÉ æÇáÕÛíÑÉ." },
    // question 74
    new { Id = 250, question = "åá åäÇß ÓíÇÓÇÊ ÎÇÕÉ ááÅáÛÇÁ¿", Response = "äÚã¡ ÊæÌÏ ÓíÇÓÇÊ ÎÇÕÉ ááÅáÛÇÁ ÊÔãá ÇáÑÓæã ÚäÏ ÇáÅáÛÇÁ ÈÚÏ İÊÑÉ ãÚíäÉ." },
    new { Id = 251, question = "Are there special cancellation policies?", Response = "Yes, there are special cancellation policies that include fees for cancellations after a certain period." },
    new { Id = 252, question = "åá åäÇß ÓíÇÓÇÊ ÎÇÕÉ ááÅáÛÇÁ¿", Response = "äÚã¡ ÊæÌÏ ÓíÇÓÇÊ ÎÇÕÉ ááÅáÛÇÁ ÊÔãá ÇáÑÓæã ÚäÏ ÇáÅáÛÇÁ ÈÚÏ İÊÑÉ ãÚíäÉ." },
    // question 75
    new { Id = 253, question = "åá ÃÓÊØíÚ ÇÓÊÆÌÇÑ ÇáÓíÇÑÉ áİÊÑÉ ŞÕíÑÉ¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÇáÓíÇÑÉ áİÊÑÇÊ ŞÕíÑÉ ãËá íæã Ãæ íæãíä." },
    new { Id = 254, question = "Can I rent the car for a short period?", Response = "Yes, you can rent the car for short periods like a day or two." },
    new { Id = 255, question = "åá ÃÓÊØíÚ ÇÓÊÆÌÇÑ ÇáÓíÇÑÉ áİÊÑÉ ŞÕíÑÉ¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÇáÓíÇÑÉ áİÊÑÇÊ ŞÕíÑÉ ãËá íæã Ãæ íæãíä." },
    // question 76
    new { Id = 256, question = "åá íãßääí ÊÛííÑ äæÚ ÇáÓíÇÑÉ ÃËäÇÁ ÇáÍÌÒ¿", Response = "äÚã¡ íãßäß ÊÛííÑ äæÚ ÇáÓíÇÑÉ ÅĞÇ ßÇäÊ ÇáÓíÇÑÉ ÇáÌÏíÏÉ ãÊÇÍÉ." },
    new { Id = 257, question = "Can I change the type of car during booking?", Response = "Yes, you can change the type of car if the new car is available." },
    new { Id = 258, question = "åá íãßääí ÊÛííÑ äæÚ ÇáÓíÇÑÉ ÃËäÇÁ ÇáÍÌÒ¿", Response = "äÚã¡ íãßäß ÊÛííÑ äæÚ ÇáÓíÇÑÉ ÅĞÇ ßÇäÊ ÇáÓíÇÑÉ ÇáÌÏíÏÉ ãÊÇÍÉ." },
    // question 77
    new { Id = 259, question = "åá ÃÓÊØíÚ ÊãÏíÏ İÊÑÉ ÇáÅíÌÇÑ¿", Response = "äÚã¡ íãßäß ÊãÏíÏ İÊÑÉ ÇáÅíÌÇÑ¡ æáßä ÈäÇÁğ Úáì ÇáÊæÇİÑ." },
    new { Id = 260, question = "Can I extend the rental period?", Response = "Yes, you can extend the rental period, but subject to availability." },
    new { Id = 261, question = "åá ÃÓÊØíÚ ÊãÏíÏ İÊÑÉ ÇáÅíÌÇÑ¿", Response = "äÚã¡ íãßäß ÊãÏíÏ İÊÑÉ ÇáÅíÌÇÑ¡ æáßä ÈäÇÁğ Úáì ÇáÊæÇİÑ." },
    // question 78
    new { Id = 262, question = "åá íãßääí ÇáÍÕæá Úáì ÊÃãíä ÖÏ ÇáÓÑŞÉ¿", Response = "äÚã¡ äŞÏã ÊÃãíä ÖÏ ÇáÓÑŞÉ áÌãíÚ ÇáÓíÇÑÇÊ ÇáãÓÊÃÌÑÉ." },
    new { Id = 263, question = "Can I get theft insurance?", Response = "Yes, we offer theft insurance for all rented cars." },
    new { Id = 264, question = "åá íãßääí ÇáÍÕæá Úáì ÊÃãíä ÖÏ ÇáÓÑŞÉ¿", Response = "äÚã¡ äŞÏã ÊÃãíä ÖÏ ÇáÓÑŞÉ áÌãíÚ ÇáÓíÇÑÇÊ ÇáãÓÊÃÌÑÉ." },
    // question 79
    new { Id = 265, question = "åá íãßääí ÊÃÌíÑ ÓíÇÑÉ ááÑÍáÇÊ ÇáÓíÇÍíÉ¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÓíÇÑÉ ááÑÍáÇÊ ÇáÓíÇÍíÉ æÇáÃãÇßä ÇáÓíÇÍíÉ." },
    new { Id = 266, question = "Can I rent a car for sightseeing trips?", Response = "Yes, you can rent a car for sightseeing and tourist spots." },
    new { Id = 267, question = "åá íãßääí ÊÃÌíÑ ÓíÇÑÉ ááÑÍáÇÊ ÇáÓíÇÍíÉ¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÓíÇÑÉ ááÑÍáÇÊ ÇáÓíÇÍíÉ æÇáÃãÇßä ÇáÓíÇÍíÉ." },
    // question 80
    new { Id = 268, question = "åá ÃÍÊÇÌ Åáì ÑÎÕÉ ŞíÇÏÉ ÏæáíÉ áÇÓÊÆÌÇÑ ÇáÓíÇÑÉ¿", Response = "ÅĞÇ ßäÊ ÛíÑ ãŞíã İí ÇáÈáÏ¡ ŞÏ ÊÍÊÇÌ Åáì ÑÎÕÉ ŞíÇÏÉ ÏæáíÉ." },
    new { Id = 269, question = "Do I need an international driving permit to rent a car?", Response = "If you are not a resident of the country, you may need an international driving permit." },
    new { Id = 270, question = "åá ÃÍÊÇÌ Åáì ÑÎÕÉ ŞíÇÏÉ ÏæáíÉ áÇÓÊÆÌÇÑ ÇáÓíÇÑÉ¿", Response = "ÅĞÇ ßäÊ ÛíÑ ãŞíã İí ÇáÈáÏ¡ ŞÏ ÊÍÊÇÌ Åáì ÑÎÕÉ ŞíÇÏÉ ÏæáíÉ." },
    // ÈíÚ æÔÑÇÁ ÓíÇÑÇÊ
    new { Id = 271, question = "ÅÒÇí ÃŞÏÑ ÃÔÊÑí ÚÑÈíÉ ãä ÇáãäÕÉ¿", Response = "ÃäÊ ããßä ÊÎÊÇÑ ÇáÚÑÈíÉ Çááí ÊäÇÓÈß ãä ÎáÇá ÊÕİÍ ÇáÓíÇÑÇÊ ÇáãÚÑæÖÉ Úáì ÇáãäÕÉ æÊÚãá ÍÌÒ ÃæäáÇíä." },
    new { Id = 272, question = "How can I buy a car from the platform?", Response = "You can choose the car that suits you by browsing the available cars on the platform and making an online reservation." },
    new { Id = 273, question = "ßíİ íãßääí ÔÑÇÁ ÓíÇÑÉ ãä ÇáãäÕÉ¿", Response = "íãßäß ÇÎÊíÇÑ ÇáÓíÇÑÉ ÇáÊí ÊäÇÓÈß ãä ÎáÇá ÊÕİÍ ÇáÓíÇÑÇÊ ÇáãÚÑæÖÉ Úáì ÇáãäÕÉ æÅÌÑÇÁ ÍÌÒ ÅáßÊÑæäí." },
    // ÊÃÌíÑ ÓíÇÑÇÊ
    new { Id = 274, question = "åá ÃŞÏÑ ÃÓÊÃÌÑ ÚÑÈíÉ áİÊÑÉ ŞÕíÑÉ¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÓíÇÑÉ áãÏÉ ŞÕíÑÉ ãËá íæã Ãæ íæãíä¡ ÍÓÈ ÇáÊæÇİÑ." },
    new { Id = 275, question = "Can I rent a car for a short period?", Response = "Yes, you can rent a car for a short period like one or two days, depending on availability." },
    new { Id = 276, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ áİÊÑÉ ŞÕíÑÉ¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÓíÇÑÉ áİÊÑÉ ŞÕíÑÉ ãËá íæã Ãæ íæãíä¡ ÍÓÈ ÇáÊæÇİÑ." },
    // ÕíÇäÉ ÇáÓíÇÑÇÊ
    new { Id = 277, question = "ßíİ ÃŞÏÑ ÃØáÈ ÕíÇäÉ ááÓíÇÑÉ¿", Response = "íãßäß ØáÈ ÎÏãÉ ÇáÕíÇäÉ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáÊæÇÕá ãÚ İÑíŞ ÇáÏÚã." },
    new { Id = 278, question = "How can I request car maintenance?", Response = "You can request car maintenance service through the app or by contacting the support team." },
    new { Id = 279, question = "ßíİ íãßääí ØáÈ ÕíÇäÉ ááÓíÇÑÉ¿", Response = "íãßäß ØáÈ ÎÏãÉ ÇáÕíÇäÉ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáÊæÇÕá ãÚ İÑíŞ ÇáÏÚã." },
    // ÛÓíá ÇáÓíÇÑÇÊ
    new { Id = 280, question = "åá íæÌÏ ÎÏãÉ ÛÓíá ÓíÇÑÇÊ¿", Response = "äÚã¡ áÏíäÇ ÎÏãÉ ÛÓíá ÇáÓíÇÑÇÊ ÇáãÊæİÑÉ ÚÈÑ ÇáÊØÈíŞ Ãæ ãä ÎáÇá ÇáÇÊÕÇá ÇáãÈÇÔÑ." },
    new { Id = 281, question = "Is there a car wash service?", Response = "Yes, we have car wash services available through the app or by direct contact." },
    new { Id = 282, question = "åá ÊæÌÏ ÎÏãÉ ÛÓíá ÓíÇÑÇÊ¿", Response = "äÚã¡ áÏíäÇ ÎÏãÉ ÛÓíá ÇáÓíÇÑÇÊ ÇáãÊæİÑÉ ÚÈÑ ÇáÊØÈíŞ Ãæ ãä ÎáÇá ÇáÇÊÕÇá ÇáãÈÇÔÑ." },
    // ŞØÚ ÛíÇÑ ÇáÓíÇÑÇÊ
    new { Id = 283, question = "åá ÃŞÏÑ ÃÔÊÑí ŞØÚ ÛíÇÑ ãä ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÔÑÇÁ ŞØÚ ÛíÇÑ ááÓíÇÑÉ ÚÈÑ ŞÓã ŞØÚ ÇáÛíÇÑ Úáì ÇáãäÕÉ." },
    new { Id = 284, question = "Can I buy car parts from the platform?", Response = "Yes, you can buy car parts through the spare parts section on the platform." },
    new { Id = 285, question = "åá íãßääí ÔÑÇÁ ŞØÚ ÛíÇÑ ááÓíÇÑÉ ãä ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÔÑÇÁ ŞØÚ ÛíÇÑ ãä ÎáÇá ŞÓã ŞØÚ ÇáÛíÇÑ Úáì ÇáãäÕÉ." },
    // İÚÇáíÇÊ ÓíÇÑÇÊ
    new { Id = 286, question = "åá åäÇß İÚÇáíÇÊ ÓíÇÑÇÊ ÊŞÇã ãä ÎáÇá ÇáãäÕÉ¿", Response = "äÚã¡ ÊŞæã ÇáãäÕÉ ÈÊäÙíã İÚÇáíÇÊ ÓíÇÑÇÊ ãËá ãÚÇÑÖ ÇáÓíÇÑÇÊ æÇáãåÑÌÇäÇÊ." },
    new { Id = 287, question = "Are there any car events organized through the platform?", Response = "Yes, the platform organizes car events like car shows and festivals." },
    new { Id = 288, question = "åá íÊã ÊäÙíã İÚÇáíÇÊ ÓíÇÑÇÊ ãä ÎáÇá ÇáãäÕÉ¿", Response = "äÚã¡ ÊŞæã ÇáãäÕÉ ÈÊäÙíã İÚÇáíÇÊ ÓíÇÑÇÊ ãËá ãÚÇÑÖ ÇáÓíÇÑÇÊ æÇáãåÑÌÇäÇÊ." },
    // æÙÇÆİ (ÓÇÆŞíä¡ İäííä ÕíÇäÉ¡ æÙÇÆİ ÊŞäíÉ)
    new { Id = 289, question = "ßíİ ÃŞÏÑ ÃÊŞÏã áæÙíİÉ ÓÇÆŞ¿", Response = "íãßäß ÇáÊŞÏã áæÙíİÉ ÓÇÆŞ ãä ÎáÇá ŞÓã ÇáæÙÇÆİ Úáì ÇáãäÕÉ." },
    new { Id = 290, question = "How can I apply for a driver job?", Response = "You can apply for a driver job through the jobs section on the platform." },
    new { Id = 291, question = "ßíİ íãßääí ÇáÊŞÏã áæÙíİÉ ÓÇÆŞ¿", Response = "íãßäß ÇáÊŞÏíã áæÙíİÉ ÓÇÆŞ ãä ÎáÇá ŞÓã ÇáæÙÇÆİ Úáì ÇáãäÕÉ." },
    // ÎÏãÇÊ ÇáÊæÕíá
    new { Id = 292, question = "åá ÊŞÏãæä ÎÏãÉ ÊæÕíá ááÓíÇÑÇÊ¿", Response = "äÚã¡ äŞÏã ÎÏãÉ ÊæÕíá ÇáÓíÇÑÇÊ ááÚãáÇÁ İí ÇáÚÏíÏ ãä ÇáãäÇØŞ." },
    new { Id = 293, question = "Do you offer car delivery service?", Response = "Yes, we offer car delivery services to customers in many areas." },
    new { Id = 294, question = "åá ÊŞÏãæä ÎÏãÉ ÊæÕíá ááÓíÇÑÇÊ¿", Response = "äÚã¡ äŞÏã ÎÏãÉ ÊæÕíá ÇáÓíÇÑÇÊ ááÚãáÇÁ İí ÇáÚÏíÏ ãä ÇáãäÇØŞ." },
    // ÇáÅáÛÇÁ æÇáÊÚÏíá İí ÇáÍÌÒ
    new { Id = 295, question = "åá íãßääí ÅáÛÇÁ ÇáÍÌÒ ÈÚÏ ÇáÊÃßíÏ¿", Response = "äÚã¡ íãßäß ÅáÛÇÁ ÇáÍÌÒ æáßä íÌÈ Ãä ÊáÊÒã ÈÓíÇÓÇÊ ÇáÅáÛÇÁ ÇáÎÇÕÉ ÈäÇ." },
    new { Id = 296, question = "Can I cancel my reservation after confirmation?", Response = "Yes, you can cancel your reservation, but you must follow our cancellation policies." },
    new { Id = 297, question = "åá íãßääí ÅáÛÇÁ ÇáÍÌÒ ÈÚÏ ÇáÊÃßíÏ¿", Response = "äÚã¡ íãßäß ÅáÛÇÁ ÇáÍÌÒ æáßä íÌÈ Ãä ÊáÊÒã ÈÓíÇÓÇÊ ÇáÅáÛÇÁ ÇáÎÇÕÉ ÈäÇ." },
    // ÇÓÊÆÌÇÑ ÓíÇÑÉ áİÊÑÇÊ ØæíáÉ
    new { Id = 298, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ áİÊÑÇÊ ØæíáÉ¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÓíÇÑÉ áİÊÑÇÊ ØæíáÉ ÍÓÈ ÇÍÊíÇÌÇÊß." },
    new { Id = 299, question = "Can I rent a car for a long period?", Response = "Yes, you can rent a car for a long period according to your needs." },
    new { Id = 300, question = "åá íãßääí ÇÓÊÆÌÇÑ ÓíÇÑÉ áİÊÑÇÊ ØæíáÉ¿", Response = "äÚã¡ íãßäß ÇÓÊÆÌÇÑ ÓíÇÑÉ áİÊÑÇÊ ØæíáÉ ÍÓÈ ÇÍÊíÇÌÇÊß." },
    // ÇáÕíÇäÉ ÃËäÇÁ İÊÑÉ ÇáÅíÌÇÑ
    new { Id = 301, question = "åá íãßääí ØáÈ ÕíÇäÉ ááÓíÇÑÉ ÃËäÇÁ İÊÑÉ ÇáÅíÌÇÑ¿", Response = "äÚã¡ íãßäß ØáÈ ÎÏãÉ ÕíÇäÉ ÎáÇá İÊÑÉ ÇáÅíÌÇÑ ÅĞÇ áÒã ÇáÃãÑ." },
    new { Id = 302, question = "Can I request maintenance for the car during the rental period?", Response = "Yes, you can request maintenance service during the rental period if needed." },
    new { Id = 303, question = "åá íãßääí ØáÈ ÕíÇäÉ ááÓíÇÑÉ ÃËäÇÁ İÊÑÉ ÇáÅíÌÇÑ¿", Response = "äÚã¡ íãßäß ØáÈ ÎÏãÉ ÕíÇäÉ ÎáÇá İÊÑÉ ÇáÅíÌÇÑ ÅĞÇ áÒã ÇáÃãÑ." },
    // ÇáÊÃãíä ÖÏ ÇáÓÑŞÉ
    new { Id = 304, question = "åá íæÌÏ ÊÃãíä ÖÏ ÇáÓÑŞÉ ááÓíÇÑÉ¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ãÄãäÉ ÖÏ ÇáÓÑŞÉ ÃËäÇÁ İÊÑÉ ÇáÅíÌÇÑ." },
    new { Id = 305, question = "Is there theft insurance for the car?", Response = "Yes, all cars are insured against theft during the rental period." },
    new { Id = 306, question = "åá íæÌÏ ÊÃãíä ÖÏ ÇáÓÑŞÉ ááÓíÇÑÉ¿", Response = "äÚã¡ ÌãíÚ ÇáÓíÇÑÇÊ ãÄãäÉ ÖÏ ÇáÓÑŞÉ ÃËäÇÁ İÊÑÉ ÇáÅíÌÇÑ." },
    // ÊÚÏíá ÇáÍÌÒ ÈÚÏ ÇáÊÎÕíÕ
    new { Id = 307, question = "åá íãßääí ÊÚÏíá ÊİÇÕíá ÇáÍÌÒ ÈÚÏ ÊÃßíÏå¿", Response = "äÚã¡ íãßäß ÊÚÏíá ÊİÇÕíá ÇáÍÌÒ ÅĞÇ Êã ØáÈ ÇáÊÚÏíá ŞÈá ãæÚÏ ÇáÇÓÊáÇã." },
    new { Id = 308, question = "Can I modify my booking details after confirmation?", Response = "Yes, you can modify your booking details if the modification is requested before the pickup time." },
    new { Id = 309, question = "åá íãßääí ÊÚÏíá ÊİÇÕíá ÇáÍÌÒ ÈÚÏ ÊÃßíÏå¿", Response = "äÚã¡ íãßäß ÊÚÏíá ÊİÇÕíá ÇáÍÌÒ ÅĞÇ Êã ØáÈ ÇáÊÚÏíá ŞÈá ãæÚÏ ÇáÇÓÊáÇã." },
    // ÎíÇÑÇÊ ÇáÏİÚ
    new { Id = 310, question = "ãÇ åí ØÑŞ ÇáÏİÚ ÇáãÊÇÍÉ¿", Response = "íãßäß ÇáÏİÚ Úä ØÑíŞ ÇáÈØÇŞÉ ÇáÇÆÊãÇäíÉ Ãæ ÇáÏİÚ äŞÏğÇ ÚäÏ ÇáÇÓÊáÇã." },
    new { Id = 311, question = "What payment methods are available?", Response = "You can pay by credit card or cash on delivery." },
    new { Id = 312, question = "ãÇ åí ØÑŞ ÇáÏİÚ ÇáãÊÇÍÉ¿", Response = "íãßäß ÇáÏİÚ Úä ØÑíŞ ÇáÈØÇŞÉ ÇáÇÆÊãÇäíÉ Ãæ ÇáÏİÚ äŞÏğÇ ÚäÏ ÇáÇÓÊáÇã." },
    // ÍÌÒ ÓíÇÑÉ ááÅíÌÇÑ
    new { Id = 313, question = "ßíİ íãßääí ÍÌÒ ÓíÇÑÉ ááÅíÌÇÑ¿", Response = "íãßäß ÍÌÒ ÇáÓíÇÑÉ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáãæŞÚ ÇáÅáßÊÑæäí." },
    new { Id = 314, question = "How can I rent a car?", Response = "You can rent a car through the app or website." },
    new { Id = 315, question = "ßíİ íãßääí ÍÌÒ ÓíÇÑÉ ááÅíÌÇÑ¿", Response = "íãßäß ÍÌÒ ÇáÓíÇÑÉ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáãæŞÚ ÇáÅáßÊÑæäí." },
    // ÈíÚ æÔÑÇÁ ãæÊæÓíßáÇÊ
    new { Id = 316, question = "åá ÇáãäÕÉ ÈÊÈíÚ ãæÊæÓíßáÇÊ¿", Response = "äÚã¡ íãßäß ÔÑÇÁ ãæÊæÓíßáÇÊ ÌÏíÏÉ Ãæ ãÓÊÚãáÉ ãä ÎáÇá ÇáãäÕÉ." },
    new { Id = 317, question = "Does the platform sell motorcycles?", Response = "Yes, you can buy new or used motorcycles through the platform." },
    new { Id = 318, question = "åá ÇáãäÕÉ ÊÈíÚ ãæÊæÓíßáÇÊ¿", Response = "äÚã¡ íãßäß ÔÑÇÁ ãæÊæÓíßáÇÊ ÌÏíÏÉ Ãæ ãÓÊÚãáÉ ãä ÎáÇá ÇáãäÕÉ." },
    // ÈíÚ ãæÊæÓíßáÇÊ
    new { Id = 319, question = "ÅÒÇí ÃŞÏÑ ÃÈíÚ ãæÊæÓíßá Úáì ÇáãäÕÉ¿", Response = "íãßäß ÚÑÖ ãæÊæÓíßáß ááÈíÚ ãä ÎáÇá ÇáÊØÈíŞ æãáÁ ÇáÈíÇäÇÊ ÇáãØáæÈÉ." },
    new { Id = 320, question = "How can I sell a motorcycle on the platform?", Response = "You can list your motorcycle for sale through the app and fill in the required details." },
    new { Id = 321, question = "ßíİ íãßääí ÈíÚ ãæÊæÓíßá Úáì ÇáãäÕÉ¿", Response = "íãßäß ÚÑÖ ãæÊæÓíßáß ááÈíÚ ãä ÎáÇá ÇáÊØÈíŞ æãáÁ ÇáÈíÇäÇÊ ÇáãØáæÈÉ." },
    // ÈíÚ æÔÑÇÁ ÚÑÈíÇÊ ßåÑÈÇÆíÉ
    new { Id = 322, question = "åá íæÌÏ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ÌÏíÏÉ ááÈíÚ¿", Response = "äÚã¡ áÏíäÇ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ÌÏíÏÉ íãßäß ÔÑÇÁåÇ ÚÈÑ ÇáãäÕÉ." },
    new { Id = 323, question = "Are there new electric cars for sale?", Response = "Yes, we have new electric cars available for purchase on the platform." },
    new { Id = 324, question = "åá íæÌÏ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ÌÏíÏÉ ááÈíÚ¿", Response = "äÚã¡ áÏíäÇ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ÌÏíÏÉ íãßäß ÔÑÇÁåÇ ÚÈÑ ÇáãäÕÉ." },
    // ÔÑÇÁ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ãÓÊÚãáÉ
    new { Id = 325, question = "åá íãßääí ÔÑÇÁ ÓíÇÑÉ ßåÑÈÇÆíÉ ãÓÊÚãáÉ¿", Response = "äÚã¡ íãßäß ÔÑÇÁ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ãÓÊÚãáÉ ãä ÎáÇá ÇáãäÕÉ." },
    new { Id = 326, question = "Can I buy a used electric car?", Response = "Yes, you can buy used electric cars through the platform." },
    new { Id = 327, question = "åá íãßääí ÔÑÇÁ ÓíÇÑÉ ßåÑÈÇÆíÉ ãÓÊÚãáÉ¿", Response = "äÚã¡ íãßäß ÔÑÇÁ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ãÓÊÚãáÉ ãä ÎáÇá ÇáãäÕÉ." },
    // ÈíÚ ÓíÇÑÇÊ ßåÑÈÇÆíÉ
    new { Id = 328, question = "ßíİ ÃŞÏÑ ÃÈíÚ ÓíÇÑÉ ßåÑÈÇÆíÉ Úáì ÇáãäÕÉ¿", Response = "íãßäß ÚÑÖ ÓíÇÑÊß ÇáßåÑÈÇÆíÉ ááÈíÚ ãä ÎáÇá ÇáÊØÈíŞ æãáÁ ÇáÊİÇÕíá ÇáãØáæÈÉ." },
    new { Id = 329, question = "How can I sell an electric car on the platform?", Response = "You can list your electric car for sale through the app and fill in the required details." },
    new { Id = 330, question = "ßíİ íãßääí ÈíÚ ÓíÇÑÉ ßåÑÈÇÆíÉ Úáì ÇáãäÕÉ¿", Response = "íãßäß ÚÑÖ ÓíÇÑÊß ÇáßåÑÈÇÆíÉ ááÈíÚ ãä ÎáÇá ÇáÊØÈíŞ æãáÁ ÇáÊİÇÕíá ÇáãØáæÈÉ." },
    // ÕíÇäÉ æŞØÚ ÛíÇÑ ááãæÊæÓíßáÇÊ æÇáÚÑÈíÇÊ ÇáßåÑÈÇÆíÉ
    new { Id = 331, question = "åá íæÌÏ ÎÏãÉ ÕíÇäÉ ááãæÊæÓíßáÇÊ Úáì ÇáãäÕÉ¿", Response = "äÚã¡ äŞÏã ÎÏãÇÊ ÕíÇäÉ ááãæÊæÓíßáÇÊ ÇáÌÏíÏÉ æÇáãÓÊÚãáÉ." },
    new { Id = 332, question = "Is there maintenance service for motorcycles on the platform?", Response = "Yes, we offer maintenance services for both new and used motorcycles." },
    new { Id = 333, question = "åá ÊæÌÏ ÎÏãÉ ÕíÇäÉ ááãæÊæÓíßáÇÊ Úáì ÇáãäÕÉ¿", Response = "äÚã¡ äŞÏã ÎÏãÇÊ ÕíÇäÉ ááãæÊæÓíßáÇÊ ÇáÌÏíÏÉ æÇáãÓÊÚãáÉ." },
    // ŞØÚ ÛíÇÑ ááãæÊæÓíßáÇÊ ÇáßåÑÈÇÆíÉ
    new { Id = 334, question = "åá íæÌÏ ŞØÚ ÛíÇÑ ááãæÊæÓíßáÇÊ ÇáßåÑÈÇÆíÉ¿", Response = "äÚã¡ áÏíäÇ ŞØÚ ÛíÇÑ ãÊæİÑÉ ááãæÊæÓíßáÇÊ ÇáßåÑÈÇÆíÉ Úáì ÇáãäÕÉ." },
    new { Id = 335, question = "Are there spare parts for electric motorcycles?", Response = "Yes, we have spare parts available for electric motorcycles on the platform." },
    new { Id = 336, question = "åá ÊæÌÏ ŞØÚ ÛíÇÑ ááãæÊæÓíßáÇÊ ÇáßåÑÈÇÆíÉ¿", Response = "äÚã¡ áÏíäÇ ŞØÚ ÛíÇÑ ãÊæİÑÉ ááãæÊæÓíßáÇÊ ÇáßåÑÈÇÆíÉ Úáì ÇáãäÕÉ." },
    // ÕíÇäÉ ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ
    new { Id = 337, question = "åá íãßääí ÕíÇäÉ ÇáÓíÇÑÉ ÇáßåÑÈÇÆíÉ ãä ÎáÇá ÇáãäÕÉ¿", Response = "äÚã¡ äÍä äŞÏã ÎÏãÇÊ ÕíÇäÉ ááÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ ÚÈÑ ÇáãäÕÉ." },
    new { Id = 338, question = "Can I service my electric car through the platform?", Response = "Yes, we offer maintenance services for electric cars through the platform." },
    new { Id = 339, question = "åá íãßääí ÕíÇäÉ ÇáÓíÇÑÉ ÇáßåÑÈÇÆíÉ ãä ÎáÇá ÇáãäÕÉ¿", Response = "äÚã¡ äÍä äŞÏã ÎÏãÇÊ ÕíÇäÉ ááÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ ÚÈÑ ÇáãäÕÉ." },
    // ÔÑÇÁ æÈíÚ ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ ÇáãÓÊÚãáÉ
    new { Id = 340, question = "åá íãßääí ÔÑÇÁ ÓíÇÑÉ ßåÑÈÇÆíÉ ãÓÊÚãáÉ ÚÈÑ ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÔÑÇÁ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ãÓÊÚãáÉ ãä ÎáÇá ÇáãäÕÉ." },
    new { Id = 341, question = "Can I buy a used electric car through the platform?", Response = "Yes, you can buy a used electric car through the platform." },
    new { Id = 342, question = "åá íãßääí ÔÑÇÁ ÓíÇÑÉ ßåÑÈÇÆíÉ ãÓÊÚãáÉ ÚÈÑ ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÔÑÇÁ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ãÓÊÚãáÉ ãä ÎáÇá ÇáãäÕÉ." },
    // ÈíÚ ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ ÇáãÓÊÚãáÉ
    new { Id = 343, question = "ßíİ íãßääí ÈíÚ ÓíÇÑÉ ßåÑÈÇÆíÉ ãÓÊÚãáÉ¿", Response = "íãßäß ÚÑÖ ÓíÇÑÊß ÇáßåÑÈÇÆíÉ ÇáãÓÊÚãáÉ ááÈíÚ ãä ÎáÇá ÇáÊØÈíŞ æãáÁ ÇáÊİÇÕíá ÇáãØáæÈÉ." },
    new { Id = 344, question = "How can I sell a used electric car?", Response = "You can list your used electric car for sale through the app and fill in the required details." },
    new { Id = 345, question = "ßíİ íãßääí ÈíÚ ÓíÇÑÉ ßåÑÈÇÆíÉ ãÓÊÚãáÉ¿", Response = "íãßäß ÚÑÖ ÓíÇÑÊß ÇáßåÑÈÇÆíÉ ÇáãÓÊÚãáÉ ááÈíÚ ãä ÎáÇá ÇáÊØÈíŞ æãáÁ ÇáÊİÇÕíá ÇáãØáæÈÉ." },
    // ÎÏãÇÊ ÔÍä ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ
    new { Id = 346, question = "åá ÊŞÏãæä ÎÏãÉ ÔÍä ááÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ¿", Response = "äÚã¡ äŞÏã ÎÏãÉ ÔÍä ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ İí ÃãÇßä ãÚíäÉ." },
    new { Id = 347, question = "Do you offer charging service for electric cars?", Response = "Yes, we offer charging services for electric cars at certain locations." },
    new { Id = 348, question = "åá ÊŞÏãæä ÎÏãÉ ÔÍä ááÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ¿", Response = "äÚã¡ äŞÏã ÎÏãÉ ÔÍä ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ İí ÃãÇßä ãÚíäÉ." }  ,
    // æÙÇÆİ İäí ÕíÇäÉ
    new { Id = 349, question = "ÅÒÇí ÃŞÏÑ ÃÊŞÏã áæÙíİÉ İäí ÕíÇäÉ¿", Response = "íãßäß ÇáÊŞÏã áæÙíİÉ İäí ÕíÇäÉ ãä ÎáÇá ŞÓã ÇáæÙÇÆİ İí ÇáÊØÈíŞ Ãæ ÇáãæŞÚ." },
    new { Id = 350, question = "How can I apply for a maintenance technician job?", Response = "You can apply for a maintenance technician job through the jobs section in the app or website." },
    new { Id = 351, question = "ßíİ ÃÓÊØíÚ ÇáÊŞÏã áæÙíİÉ İäí ÕíÇäÉ¿", Response = "íãßäß ÇáÊŞÏíã áæÙíİÉ İäí ÕíÇäÉ ãä ÎáÇá ŞÓã ÇáæÙÇÆİ İí ÇáÊØÈíŞ Ãæ ÇáãæŞÚ." },

    new { Id = 352, question = "åá İí İÑÕ áæÙÇÆİ İäí ÕíÇäÉ¿", Response = "äÚã¡ åäÇß ÇáÚÏíÏ ãä İÑÕ ÇáÚãá ÇáãÊÇÍÉ áæÙÇÆİ İäí ÕíÇäÉ¡ íãßäß ÇáÊŞÏíã ãä ÎáÇá ÇáãæŞÚ." },
    new { Id = 353, question = "Are there opportunities for maintenance technician jobs?", Response = "Yes, there are many job opportunities available for maintenance technician positions. You can apply through the website." },
    new { Id = 354, question = "åá ÊæÌÏ İÑÕ áæÙÇÆİ İäí ÕíÇäÉ¿", Response = "äÚã¡ åäÇß ÇáÚÏíÏ ãä ÇáİÑÕ ÇáãÊÇÍÉ áæÙÇÆİ İäí ÕíÇäÉ¡ íãßäß ÇáÊŞÏíã ãä ÎáÇá ÇáãæŞÚ." },

    // æÙÇÆİ ÊØæíÑ ÇáÊŞäíÉ
    new { Id = 355, question = "åá İí æÙÇÆİ İí ãÌÇá ÊØæíÑ ÇáÊŞäíÉ¿", Response = "äÚã¡ áÏíäÇ æÙÇÆİ ÔÇÛÑÉ İí ãÌÇáÇÊ ÊØæíÑ ÇáÊØÈíŞÇÊ æÇáãæÇŞÚ ÇáÅáßÊÑæäíÉ¡ íãßäß ÇáÊŞÏíã ãä ÎáÇá ŞÓã ÇáæÙÇÆİ." },
    new { Id = 356, question = "Are there technology development jobs available?", Response = "Yes, we have job openings in app and website development. You can apply through the jobs section." },
    new { Id = 357, question = "åá ÊæÌÏ æÙÇÆİ İí ãÌÇá ÊØæíÑ ÇáÊŞäíÉ¿", Response = "äÚã¡ áÏíäÇ æÙÇÆİ ÔÇÛÑÉ İí ãÌÇáÇÊ ÊØæíÑ ÇáÊØÈíŞÇÊ æÇáãæÇŞÚ ÇáÅáßÊÑæäíÉ¡ íãßäß ÇáÊŞÏíã ãä ÎáÇá ŞÓã ÇáæÙÇÆİ." },

    new { Id = 358, question = "ßíİ ÃŞÏÑ ÃÊŞÏã áæÙíİÉ ãØæÑ æíÈ¿", Response = "íãßäß ÇáÊŞÏã áæÙíİÉ ãØæÑ æíÈ ãä ÎáÇá ŞÓã ÇáæÙÇÆİ Úáì ÇáãäÕÉ." },
    new { Id = 359, question = "How can I apply for a web developer job?", Response = "You can apply for a web developer job through the jobs section on the platform." },
    new { Id = 360, question = "ßíİ íãßääí ÇáÊŞÏã áæÙíİÉ ãØæÑ æíÈ¿", Response = "íãßäß ÇáÊŞÏã áæÙíİÉ ãØæÑ æíÈ ãä ÎáÇá ŞÓã ÇáæÙÇÆİ Úáì ÇáãäÕÉ." },

    new { Id = 361, question = "åá İí İÑÕ áæÙÇÆİ ãØæÑí ÊØÈíŞÇÊ¿", Response = "äÚã¡ äÈÍË ÏÇÆãğÇ Úä ãØæÑí ÊØÈíŞÇÊ ãÈÊßÑíä ááÇäÖãÇã áİÑíŞ ÇáÚãá." },
    new { Id = 362, question = "Are there opportunities for app developer jobs?", Response = "Yes, we are always looking for innovative app developers to join the team." },
    new { Id = 363, question = "åá ÊæÌÏ İÑÕ áæÙÇÆİ ãØæÑí ÊØÈíŞÇÊ¿", Response = "äÚã¡ äÈÍË ÏÇÆãğÇ Úä ãØæÑí ÊØÈíŞÇÊ ãÈÊßÑíä ááÇäÖãÇã áİÑíŞ ÇáÚãá." },

    new { Id = 364, question = "åá ÃŞÏÑ ÃŞÏã áæÙíİÉ ãåäÏÓ ÈÑãÌíÇÊ¿", Response = "äÚã¡ íãßäß ÇáÊŞÏíã áæÙíİÉ ãåäÏÓ ÈÑãÌíÇÊ ãä ÎáÇá ŞÓã ÇáæÙÇÆİ ÇáãÊÇÍÉ Úáì ÇáãäÕÉ." },
    new { Id = 365, question = "Can I apply for a software engineer job?", Response = "Yes, you can apply for a software engineer job through the available job section on the platform." },
    new { Id = 366, question = "åá íãßääí ÇáÊŞÏíã áæÙíİÉ ãåäÏÓ ÈÑãÌíÇÊ¿", Response = "äÚã¡ íãßäß ÇáÊŞÏíã áæÙíİÉ ãåäÏÓ ÈÑãÌíÇÊ ãä ÎáÇá ŞÓã ÇáæÙÇÆİ ÇáãÊÇÍÉ Úáì ÇáãäÕÉ." },

    // æÙÇÆİ İäííä ãÎÊÕíä İí ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ
    new { Id = 367, question = "åá İí æÙÇÆİ İäí ÕíÇäÉ ÎÇÕÉ ÈÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ¿", Response = "äÚã¡ åäÇß İÑÕ áæÙÇÆİ İäííä ÕíÇäÉ ãÎÊÕíä İí ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ. íãßäß ÇáÊŞÏíã ÚÈÑ ŞÓã ÇáæÙÇÆİ." },
    new { Id = 368, question = "Are there jobs for electric car maintenance technicians?", Response = "Yes, there are opportunities for electric car maintenance technicians. You can apply through the jobs section." },
    new { Id = 369, question = "åá ÊæÌÏ æÙÇÆİ İäí ÕíÇäÉ ãÎÊÕ İí ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ¿", Response = "äÚã¡ åäÇß İÑÕ áæÙÇÆİ İäííä ÕíÇäÉ ãÎÊÕíä İí ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ. íãßäß ÇáÊŞÏíã ÚÈÑ ŞÓã ÇáæÙÇÆİ." },

    new { Id = 370, question = "ÅÒÇí ÃŞÏÑ Ãßæä İäí ÕíÇäÉ ÓíÇÑÇÊ ßåÑÈÇÆíÉ¿", Response = "áÊßæä İäí ÕíÇäÉ ááÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ¡ íãßäß ÇáÊŞÏíã áæÙÇÆİ ÇáÊÏÑíÈ ÇáãÊÇÍÉ áÏíäÇ." },
    new { Id = 371, question = "How can I become an electric car maintenance technician?", Response = "To become an electric car maintenance technician, you can apply for available training jobs with us." },
    new { Id = 372, question = "ßíİ íãßääí Ãä Ãßæä İäí ÕíÇäÉ ÓíÇÑÇÊ ßåÑÈÇÆíÉ¿", Response = "áÊßæä İäí ÕíÇäÉ ááÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ¡ íãßäß ÇáÊŞÏíã áæÙÇÆİ ÇáÊÏÑíÈ ÇáãÊÇÍÉ áÏíäÇ." },

    // æÙÇÆİ ÊŞäíÉ ãÊÎÕÕÉ
    new { Id = 373, question = "åá íæÌÏ æÙÇÆİ ÊŞäíÉ ãÊÎÕÕÉ İí ÊØæíÑ ÊØÈíŞÇÊ ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ áÏíäÇ æÙÇÆİ ÎÇÕÉ ÈÊØæíÑ ÇáÊØÈíŞÇÊ ÇáãÑÊÈØÉ ÈÎÏãÇÊ ÇáÓíÇÑÇÊ. íãßäß ÇáÊŞÏíã ãä ÎáÇá ŞÓã ÇáæÙÇÆİ." },
    new { Id = 374, question = "Are there specialized tech jobs in car app development?", Response = "Yes, we have jobs related to the development of apps for car services. You can apply through the jobs section." },
    new { Id = 375, question = "åá ÊæÌÏ æÙÇÆİ ÊŞäíÉ ãÊÎÕÕÉ İí ÊØæíÑ ÊØÈíŞÇÊ ÇáÓíÇÑÇÊ¿", Response = "äÚã¡ áÏíäÇ æÙÇÆİ ÎÇÕÉ ÈÊØæíÑ ÇáÊØÈíŞÇÊ ÇáãÑÊÈØÉ ÈÎÏãÇÊ ÇáÓíÇÑÇÊ. íãßäß ÇáÊŞÏíã ãä ÎáÇá ŞÓã ÇáæÙÇÆİ." },

    // æÙÇÆİ İäííä ááÃäÙãÉ ÇáÊŞäíÉ ÇáÎÇÕÉ ÈÇáÓíÇÑÇÊ
    new { Id = 376, question = "åá İí æÙÇÆİ áİäííä ãÎÊÕíä İí ÇáÃäÙãÉ ÇáÊŞäíÉ ááÓíÇÑÇÊ¿", Response = "äÚã¡ åäÇß æÙÇÆİ áİäííä ãÊÎÕÕíä İí ÇáÃäÙãÉ ÇáÊŞäíÉ ááÓíÇÑÇÊ ãËá ÃäÙãÉ ÇáÊæÌíå æÇáãÑÇŞÈÉ." },
    new { Id = 377, question = "Are there jobs for technicians specialized in car tech systems?", Response = "Yes, there are jobs for technicians specialized in car tech systems such as steering and monitoring systems." },
    new { Id = 378, question = "åá ÊæÌÏ æÙÇÆİ áİäííä ãÎÊÕíä İí ÇáÃäÙãÉ ÇáÊŞäíÉ ááÓíÇÑÇÊ¿", Response = "äÚã¡ åäÇß æÙÇÆİ áİäííä ãÊÎÕÕíä İí ÇáÃäÙãÉ ÇáÊŞäíÉ ááÓíÇÑÇÊ ãËá ÃäÙãÉ ÇáÊæÌíå æÇáãÑÇŞÈÉ." },
    // æÙÇÆİ İäí ÕíÇäÉ ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ
    new { Id = 379, question = "åá İí æÙÇÆİ áİäí ÕíÇäÉ ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ¿", Response = "äÚã¡ åäÇß ÇáÚÏíÏ ãä ÇáİÑÕ ÇáãÊÇÍÉ áİäíí ÕíÇäÉ ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ. íãßäßã ÇáÊŞÏíã ãä ÎáÇá ÇáãäÕÉ." },
    new { Id = 380, question = "Are there jobs for electric car maintenance technicians?", Response = "Yes, there are many opportunities for electric car maintenance technicians. You can apply through the platform." },
    new { Id = 381, question = "åá ÊæÌÏ æÙÇÆİ áİäí ÕíÇäÉ ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ¿", Response = "äÚã¡ åäÇß ÇáÚÏíÏ ãä ÇáİÑÕ ÇáãÊÇÍÉ áİäíí ÕíÇäÉ ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ. íãßäßã ÇáÊŞÏíã ãä ÎáÇá ÇáãäÕÉ." },

    // æÙÇÆİ ÊØæíÑ ÇáãæÇŞÚ æÇáÊØÈíŞÇÊ
    new { Id = 382, question = "åá íãßääí ÇáÊŞÏíã áæÙíİÉ ãØæÑ ÊØÈíŞÇÊ¿", Response = "äÚã¡ íãßäß ÇáÊŞÏíã áæÙíİÉ ãØæÑ ÊØÈíŞÇÊ ãä ÎáÇá ŞÓã ÇáæÙÇÆİ ÇáãÊÇÍÉ İí ÇáãäÕÉ." },
    new { Id = 383, question = "Can I apply for an app developer job?", Response = "Yes, you can apply for an app developer job through the available jobs section on the platform." },
    new { Id = 384, question = "åá íãßääí ÇáÊŞÏíã áæÙíİÉ ãØæÑ ÊØÈíŞÇÊ¿", Response = "äÚã¡ íãßäß ÇáÊŞÏíã áæÙíİÉ ãØæÑ ÊØÈíŞÇÊ ãä ÎáÇá ŞÓã ÇáæÙÇÆİ ÇáãÊÇÍÉ İí ÇáãäÕÉ." },

    new { Id = 385, question = "åá åäÇß æÙÇÆİ İí ÊØæíÑ ÇáãæÇŞÚ¿", Response = "äÚã¡ åäÇß ÇáÚÏíÏ ãä ÇáæÙÇÆİ ÇáãÊÇÍÉ İí ÊØæíÑ ÇáãæÇŞÚ. íãßäß ÇáÊŞÏíã ãä ÎáÇá ÇáãäÕÉ." },
    new { Id = 386, question = "Are there jobs available in website development?", Response = "Yes, there are many jobs available in website development. You can apply through the platform." },
    new { Id = 387, question = "åá ÊæÌÏ æÙÇÆİ İí ÊØæíÑ ÇáãæÇŞÚ¿", Response = "äÚã¡ åäÇß ÇáÚÏíÏ ãä ÇáæÙÇÆİ ÇáãÊÇÍÉ İí ÊØæíÑ ÇáãæÇŞÚ. íãßäß ÇáÊŞÏíã ãä ÎáÇá ÇáãäÕÉ." },

    // æÙÇÆİ ãÊÚáŞÉ ÈÈíÚ æÔÑÇÁ ÇáÓíÇÑÇÊ
    new { Id = 388, question = "ßíİ íãßääí ÔÑÇÁ ÓíÇÑÉ ÚÈÑ ÇáãäÕÉ¿", Response = "íãßäß ÔÑÇÁ ÓíÇÑÉ ãä ÎáÇá ÊÕİÍ ÇáÚÑæÖ ÇáãÊÇÍÉ İí ŞÓã ÈíÚ ÇáÓíÇÑÇÊ æÇÎÊíÇÑ ÇáÃäÓÈ áß." },
    new { Id = 389, question = "How can I buy a car through the platform?", Response = "You can buy a car by browsing the available listings in the car sales section and choosing the one that suits you." },
    new { Id = 390, question = "ßíİ ÃÓÊØíÚ ÔÑÇÁ ÓíÇÑÉ ÚÈÑ ÇáãäÕÉ¿", Response = "íãßäß ÔÑÇÁ ÓíÇÑÉ ãä ÎáÇá ÊÕİÍ ÇáÚÑæÖ ÇáãÊÇÍÉ İí ŞÓã ÈíÚ ÇáÓíÇÑÇÊ æÇÎÊíÇÑ ÇáÃäÓÈ áß." },

    new { Id = 391, question = "åá íãßääí ÈíÚ ÓíÇÑÊí ÚÈÑ ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÈíÚ ÓíÇÑÊß ãä ÎáÇá ÅÖÇİÉ ÚÑÖ ÈíÚ ááÓíÇÑÉ İí ŞÓã ÈíÚ ÇáÓíÇÑÇÊ." },
    new { Id = 392, question = "Can I sell my car through the platform?", Response = "Yes, you can sell your car by adding a car listing in the car sales section." },
    new { Id = 393, question = "åá ÃÓÊØíÚ ÈíÚ ÓíÇÑÊí ÚÈÑ ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÈíÚ ÓíÇÑÊß ãä ÎáÇá ÅÖÇİÉ ÚÑÖ ÈíÚ ááÓíÇÑÉ İí ŞÓã ÈíÚ ÇáÓíÇÑÇÊ." },

    // ÈíÚ æÔÑÇÁ ãæÊæÓíßáÇÊ
    new { Id = 394, question = "åá ÇáãäÕÉ ÊÈíÚ ãæÊæÓíßáÇÊ¿", Response = "äÚã¡ íãßäß ÇáÚËæÑ Úáì ÚÑæÖ ÈíÚ ãæÊæÓíßáÇÊ ÌÏíÏÉ æãÓÊÚãáÉ Úáì ÇáãäÕÉ." },
    new { Id = 395, question = "Does the platform sell motorcycles?", Response = "Yes, you can find listings for new and used motorcycles on the platform." },
    new { Id = 396, question = "åá ÊæÌÏ ÚÑæÖ áÈíÚ ãæÊæÓíßáÇÊ Úáì ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÇáÚËæÑ Úáì ÚÑæÖ ÈíÚ ãæÊæÓíßáÇÊ ÌÏíÏÉ æãÓÊÚãáÉ Úáì ÇáãäÕÉ." },

    new { Id = 397, question = "åá íãßääí ÈíÚ ãæÊæÓíßá ÚÈÑ ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÈíÚ ãæÊæÓíßá ãä ÎáÇá ÅÖÇİÉ ÚÑÖ İí ŞÓã ÈíÚ ÇáãæÊæÓíßáÇÊ." },
    new { Id = 398, question = "Can I sell a motorcycle through the platform?", Response = "Yes, you can sell a motorcycle by adding a listing in the motorcycle sales section." },
    new { Id = 399, question = "åá ÃÓÊØíÚ ÈíÚ ãæÊæÓíßá ÚÈÑ ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÈíÚ ãæÊæÓíßá ãä ÎáÇá ÅÖÇİÉ ÚÑÖ İí ŞÓã ÈíÚ ÇáãæÊæÓíßáÇÊ." },

    // ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ
    new { Id = 400, question = "åá ÇáãäÕÉ ÊÈíÚ ÓíÇÑÇÊ ßåÑÈÇÆíÉ¿", Response = "äÚã¡ íãßäß ÇáÚËæÑ Úáì ÓíÇÑÇÊ ßåÑÈÇÆíÉ ÌÏíÏÉ æãÓÊÚãáÉ ÚÈÑ ÇáãäÕÉ." },
    new { Id = 401, question = "Does the platform sell electric cars?", Response = "Yes, you can find new and used electric cars on the platform." },
    new { Id = 402, question = "åá ÊæÌÏ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ááÈíÚ Úáì ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÇáÚËæÑ Úáì ÓíÇÑÇÊ ßåÑÈÇÆíÉ ÌÏíÏÉ æãÓÊÚãáÉ ÚÈÑ ÇáãäÕÉ." },

    new { Id = 403, question = "ßíİ íãßääí ÔÑÇÁ ÓíÇÑÉ ßåÑÈÇÆíÉ¿", Response = "íãßäß ÔÑÇÁ ÓíÇÑÉ ßåÑÈÇÆíÉ ãä ÎáÇá ÊÕİÍ ÇáÚÑæÖ ÇáãÊÇÍÉ İí ŞÓã ÈíÚ ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ." },
    new { Id = 404, question = "How can I buy an electric car?", Response = "You can buy an electric car by browsing the listings in the electric car sales section." },
    new { Id = 405, question = "ßíİ ÃÓÊØíÚ ÔÑÇÁ ÓíÇÑÉ ßåÑÈÇÆíÉ¿", Response = "íãßäß ÔÑÇÁ ÓíÇÑÉ ßåÑÈÇÆíÉ ãä ÎáÇá ÊÕİÍ ÇáÚÑæÖ ÇáãÊÇÍÉ İí ŞÓã ÈíÚ ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ." },
    // æÙÇÆİ ÃÎÑì İí ãÌÇá ÇáÊŞäíÉ
    new { Id = 406, question = "åá İí æÙÇÆİ ÃÎÑì İí ãÌÇá ÇáÊŞäíÉ¿", Response = "äÚã¡ áÏíäÇ æÙÇÆİ ãÊÇÍÉ İí ãÌÇáÇÊ ÊØæíÑ ÇáÈÑãÌíÇÊ¡ ÇáÔÈßÇÊ¡ æÊÕãíã ÇáæÇÌåÇÊ." },
    new { Id = 407, question = "Are there other jobs in the tech field?", Response = "Yes, we have openings in software development, networking, and UI/UX design." },
    new { Id = 408, question = "åá ÊæÌÏ æÙÇÆİ ÃÎÑì İí ãÌÇá ÇáÊŞäíÉ¿", Response = "äÚã¡ áÏíäÇ æÙÇÆİ ãÊÇÍÉ İí ãÌÇáÇÊ ÊØæíÑ ÇáÈÑãÌíÇÊ¡ ÇáÔÈßÇÊ¡ æÊÕãíã ÇáæÇÌåÇÊ." },

    new { Id = 409, question = "ßíİ ÃŞÏÑ ÃÊŞÏã áæÙíİÉ İí ãÌÇá ÇáÊŞäíÉ¿", Response = "íãßäß ÇáÊŞÏíã ãä ÎáÇá ŞÓã ÇáæÙÇÆİ İí ÇáãäÕÉ æÇÎÊíÇÑ ÇáæÙíİÉ ÇáÊí ÊäÇÓÈ ãåÇÑÇÊß." },
    new { Id = 410, question = "How can I apply for a tech job?", Response = "You can apply through the jobs section on the platform and choose the job that fits your skills." },
    new { Id = 411, question = "ßíİ íãßääí ÇáÊŞÏã áæÙíİÉ İí ãÌÇá ÇáÊŞäíÉ¿", Response = "íãßäß ÇáÊŞÏíã ãä ÎáÇá ŞÓã ÇáæÙÇÆİ İí ÇáãäÕÉ æÇÎÊíÇÑ ÇáæÙíİÉ ÇáÊí ÊäÇÓÈ ãåÇÑÇÊß." },

    // ÃÓÆáÉ Úä ÎÏãÇÊ ÛÓíá ÇáÓíÇÑÇÊ
    new { Id = 412, question = "ßíİ íãßääí ÍÌÒ ÎÏãÉ ÛÓíá ÓíÇÑÇÊ¿", Response = "íãßäß ÍÌÒ ÎÏãÉ ÛÓíá ÇáÓíÇÑÇÊ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáãæŞÚ æÇÎÊíÇÑ ÇáÎÏãÉ ÇáãäÇÓÈÉ áß." },
    new { Id = 413, question = "How can I book a car washing service?", Response = "You can book a car washing service through the app or website and select the service that suits you." },
    new { Id = 414, question = "ßíİ ÃÓÊØíÚ ÍÌÒ ÎÏãÉ ÛÓíá ÓíÇÑÇÊ¿", Response = "íãßäß ÍÌÒ ÎÏãÉ ÛÓíá ÇáÓíÇÑÇÊ ãä ÎáÇá ÇáÊØÈíŞ Ãæ ÇáãæŞÚ æÇÎÊíÇÑ ÇáÎÏãÉ ÇáãäÇÓÈÉ áß." },

    new { Id = 415, question = "åá íãßääí ÊÎÕíÕ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ¿", Response = "äÚã¡ íãßäß ÊÎÕíÕ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ æİŞğÇ áÇÍÊíÇÌÇÊß¡ ãËá ÅÖÇİÉ ÊäÙíİ ÏÇÎáí Ãæ ÊäÙíİ ÇáÚÌáÇÊ." },
    new { Id = 416, question = "Can I customize my car washing service?", Response = "Yes, you can customize your car washing service according to your needs, such as adding interior cleaning or wheel cleaning." },
    new { Id = 417, question = "åá íãßääí ÊÎÕíÕ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ¿", Response = "äÚã¡ íãßäß ÊÎÕíÕ ÎÏãÉ ÛÓíá ÇáÓíÇÑÉ æİŞğÇ áÇÍÊíÇÌÇÊß¡ ãËá ÅÖÇİÉ ÊäÙíİ ÏÇÎáí Ãæ ÊäÙíİ ÇáÚÌáÇÊ." },

    // ÃÓÆáÉ Úä ÎÏãÉ ÇáÊæÕíá
    new { Id = 418, question = "ßíİ íãßääí ØáÈ ÎÏãÉ ÊæÕíá¿", Response = "íãßäß ØáÈ ÎÏãÉ ÇáÊæÕíá ãä ÎáÇá ÊØÈíŞäÇ Ãæ ÇáãæŞÚ¡ İŞØ ÇÎÊÑ ÇáãßÇä æÇáæŞÊ ÇáãäÇÓÈ áß." },
    new { Id = 419, question = "How can I request a delivery service?", Response = "You can request a delivery service through our app or website by selecting the location and time that suits you." },
    new { Id = 420, question = "ßíİ ÃÓÊØíÚ ØáÈ ÎÏãÉ ÊæÕíá¿", Response = "íãßäß ØáÈ ÎÏãÉ ÇáÊæÕíá ãä ÎáÇá ÊØÈíŞäÇ Ãæ ÇáãæŞÚ¡ İŞØ ÇÎÊÑ ÇáãßÇä æÇáæŞÊ ÇáãäÇÓÈ áß." },

    new { Id = 421, question = "åá ÎÏãÉ ÇáÊæÕíá ãÊÇÍÉ İí ÌãíÚ ÇáãäÇØŞ¿", Response = "äÚã¡ ÎÏãÉ ÇáÊæÕíá ãÊÇÍÉ İí ÇáÚÏíÏ ãä ÇáãäÇØŞ. íãßäß ÇáÊÍŞŞ ãä ÊæİÑ ÇáÎÏãÉ İí ãäØŞÊß ÚÈÑ ÇáÊØÈíŞ." },
    new { Id = 422, question = "Is the delivery service available in all areas?", Response = "Yes, the delivery service is available in many areas. You can check the availability in your area through the app." },
    new { Id = 423, question = "åá ÎÏãÉ ÇáÊæÕíá ãÊÇÍÉ İí ßá ÇáãäÇØŞ¿", Response = "äÚã¡ ÎÏãÉ ÇáÊæÕíá ãÊÇÍÉ İí ÇáÚÏíÏ ãä ÇáãäÇØŞ. íãßäß ÇáÊÍŞŞ ãä ÊæİÑ ÇáÎÏãÉ İí ãäØŞÊß ÚÈÑ ÇáÊØÈíŞ." },

    // ÃÓÆáÉ Úä ŞØÚ ÇáÛíÇÑ
    new { Id = 424, question = "ßíİ ÃŞÏÑ ÃÔÊÑí ŞØÚ ÛíÇÑ¿", Response = "íãßäß ÔÑÇÁ ŞØÚ ÇáÛíÇÑ ãä ÎáÇá ŞÓã ÈíÚ ŞØÚ ÇáÛíÇÑ İí ÇáÊØÈíŞ Ãæ ÇáãæŞÚ." },
    new { Id = 425, question = "How can I buy spare parts?", Response = "You can buy spare parts through the spare parts section on the app or website." },
    new { Id = 426, question = "ßíİ ÃÓÊØíÚ ÔÑÇÁ ŞØÚ ÛíÇÑ¿", Response = "íãßäß ÔÑÇÁ ŞØÚ ÇáÛíÇÑ ãä ÎáÇá ŞÓã ÈíÚ ŞØÚ ÇáÛíÇÑ İí ÇáÊØÈíŞ Ãæ ÇáãæŞÚ." },

    new { Id = 427, question = "åá íãßääí ÔÑÇÁ ŞØÚ ÛíÇÑ ááÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ¿", Response = "äÚã¡ íãßäß ÔÑÇÁ ŞØÚ ÛíÇÑ ááÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ ãä ŞÓã ŞØÚ ÇáÛíÇÑ ÇáãÊÇÍ Úáì ÇáãäÕÉ." },
    new { Id = 428, question = "Can I buy spare parts for electric cars?", Response = "Yes, you can buy spare parts for electric cars from the spare parts section available on the platform." },
    new { Id = 429, question = "åá ÊæÌÏ ŞØÚ ÛíÇÑ ááÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ¿", Response = "äÚã¡ íãßäß ÔÑÇÁ ŞØÚ ÛíÇÑ ááÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ ãä ŞÓã ŞØÚ ÇáÛíÇÑ ÇáãÊÇÍ Úáì ÇáãäÕÉ." },

    // ÃÓÆáÉ Úä ÈíÚ ÇáÓíÇÑÇÊ ÇáãÓÊÚãáÉ
    new { Id = 430, question = "åá íãßääí ÈíÚ ÓíÇÑÊí ÇáãÓÊÚãáÉ ÚÈÑ ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÈíÚ ÓíÇÑÊß ÇáãÓÊÚãáÉ ãä ÎáÇá ÅÖÇİÉ ÚÑÖ ááÈíÚ İí ŞÓã ÇáÓíÇÑÇÊ ÇáãÓÊÚãáÉ." },
    new { Id = 431, question = "Can I sell my used car through the platform?", Response = "Yes, you can sell your used car by adding a listing in the used car section." },
    new { Id = 432, question = "åá ÃÓÊØíÚ ÈíÚ ÓíÇÑÊí ÇáãÓÊÚãáÉ ÚÈÑ ÇáãäÕÉ¿", Response = "äÚã¡ íãßäß ÈíÚ ÓíÇÑÊß ÇáãÓÊÚãáÉ ãä ÎáÇá ÅÖÇİÉ ÚÑÖ ááÈíÚ İí ŞÓã ÇáÓíÇÑÇÊ ÇáãÓÊÚãáÉ." },

    // ÃÓÆáÉ Úä ÇáÓíÇÑÇÊ ÇáßåÑÈÇÆíÉ ÇáãÓÊÚãáÉ
    new { Id = 433, question = "åá íæÌÏ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ãÓÊÚãáÉ ááÈíÚ¿", Response = "äÚã¡ áÏíäÇ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ãÓÊÚãáÉ ááÈíÚ¡ íãßäß ÇáÇØáÇÚ Úáì ÇáÚÑæÖ ÇáãÊÇÍÉ." },
    new { Id = 434, question = "Are there used electric cars for sale?", Response = "Yes, we have used electric cars for sale. You can check the available listings." },
    new { Id = 435, question = "åá ÊæÌÏ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ãÓÊÚãáÉ ááÈíÚ¿", Response = "äÚã¡ áÏíäÇ ÓíÇÑÇÊ ßåÑÈÇÆíÉ ãÓÊÚãáÉ ááÈíÚ¡ íãßäß ÇáÇØáÇÚ Úáì ÇáÚÑæÖ ÇáãÊÇÍÉ." }
);

        }
    }
}
