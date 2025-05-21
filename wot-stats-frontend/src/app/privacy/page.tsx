export default function Privacy() {
  return (
    <div className="container mx-auto max-w-4xl px-6 py-12">
      <div className="flex flex-col gap-8">
        <div className="border-b pb-6">
          <h1 className="text-3xl font-bold mb-4">Security Policy WOT-STATS</h1>
        </div>

        <section>
          <h2 className="text-2xl font-semibold mb-4">General Provisions</h2>
          <p className="text-gray-700 dark:text-gray-300 leading-relaxed">
            WOT-STATS protects the privacy of personal data of customers who
            visit this website and use its services. Amendments to this privacy
            policy, if any, will be posted on WOT-STATS and will become
            effective immediately after they are posted. Your continued use of
            our service following the posting of any changes to our privacy
            policy constitutes your acceptance of those changes.
          </p>
        </section>

        <section>
          <h2 className="text-2xl font-semibold mb-4">
            Collection and Storage of Information
          </h2>
          <p className="text-gray-700 dark:text-gray-300 leading-relaxed">
            WOT-STATS collect, store and use user information solely to provide
            our services, as well as inform users about changes in prices, terms
            of service, promotions and introductory materials.
          </p>
        </section>

        <section>
          <h2 className="text-2xl font-semibold mb-4">
            Use of Personal Information
          </h2>
          <p className="text-gray-700 dark:text-gray-300 mb-4">
            We may use personal information for the following purposes:
          </p>
          <ul className="list-disc pl-6 space-y-2 text-gray-700 dark:text-gray-300">
            <li>
              To inform about the status of the order and all related work on
              the order.
            </li>
            <li>
              To improve the quality of service and the operation of the service
              as a whole.
            </li>
            <li>To send information related to changes on the site.</li>
          </ul>
        </section>

        <section>
          <h2 className="text-2xl font-semibold mb-4">
            Protection of Personal Information
          </h2>
          <p className="text-gray-700 dark:text-gray-300 mb-4">
            WOT-STATS uses the following personal data protection methods:
          </p>
          <ul className="list-disc pl-6 space-y-2 text-gray-700 dark:text-gray-300">
            <li>
              SSL encryption protocol with which we protect all personal data.
            </li>
            <li>
              Acceptance of data on credit cards and other payment methods
              occurs through the payment buffer and not directly through
              WOT-STATS.
            </li>
            <li>
              All security measures have been taken on the current hosting. The
              server is regularly checked for malware to protect personal data.
            </li>
          </ul>
        </section>

        <section>
          <h2 className="text-2xl font-semibold mb-4">
            Providing Information to Third Parties
          </h2>
          <p className="text-gray-700 dark:text-gray-300 leading-relaxed">
            WOT-STATS under no circumstances transfers user data and any other
            information provided by the user to third parties. The use of your
            personal data on third-party sites already falls under the privacy
            policy of these same sites.
          </p>
        </section>

        <section>
          <h2 className="text-2xl font-semibold mb-4">
            Deletion of Personal Data
          </h2>
          <p className="text-gray-700 dark:text-gray-300 mb-4">
            Users and customers can always delete their data in one of the
            following ways:
          </p>
          <div className="bg-gray-50 dark:bg-gray-800 p-4 rounded-lg">
            <p className="text-gray-700 dark:text-gray-300">
              <span className="font-medium">By email:</span> write to
              <a
                href="mailto:help@wot-stats.fun"
                className="text-blue-600 dark:text-blue-400 hover:underline ml-1"
              >
                help@wot-stats.fun
              </a>
            </p>
          </div>
        </section>

        <section className="mt-8 pt-6 border-t text-sm text-gray-500 dark:text-gray-400">
          <p>Last updated: April 24, 2025</p>
        </section>
      </div>
    </div>
  );
}
